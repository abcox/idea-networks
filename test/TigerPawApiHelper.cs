using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using test.Models.ProQuote;
using test.Models.TigerPaw;
using test.Models.TigerPaw.Responses;

namespace test
{
    /// TigerPawApiHelper
    /// 
    /// <summary>
    /// Additional API documentation found at
    /// https://api2.tigerpawsoftware.com/docs/index
    /// </summary>

    class TigerPawApiHelper
    {
        public TigerPawApiHelper(
            string serviceUrl,
            string publicKey,
            string privateKey
            )
        {
            _baseUri = serviceUrl;
            _publicKey = publicKey;
            _privateKey = privateKey;

            try
            {
                //UserAuthentication(); response 200 recieved 2019-03-18

                //AdvancedSearch();

                //OpportunityDocuments();

                //AttachDocumentToOpportunity();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        //private const string BaseUri = @"https://api2.tigerpawsoftware.com"; // @"http://api.ideanetworks.com";
        private string _baseUri = @"https://api2.tigerpawsoftware.com"; // @"http://api.ideanetworks.com";
        private const string DefaultAcceptHeader = "application/xml";

        //todo: need to replace the public and private keys
        //private const string DefaultPublicKey = [Public Key];
        //private const string DefaultPrivateKey = [Private Key];
        private readonly string _publicKey;
        private readonly string _privateKey;
        private string DefaultPublicKey { get { return _publicKey; } }
        private string DefaultPrivateKey { get { return _privateKey; } }

        private static void PrintAccountName(XElement element)
        {
            var name = (from i in element.Descendants("Account")
                        let xName = i.Element("Name")
                        select xName.Value).FirstOrDefault();

            Console.WriteLine(name ?? "Not Found");

        }

        private static void PrintDocumentTitle(XElement element)
        {
            var name = (from i in element.Descendants("Document")
                        let xName = i.Element("Title")
                        select xName.Value).FirstOrDefault();

            Console.WriteLine(name ?? "Not Found");
        }

        private static string GenerateHmacSha256Token(string message, string secret)
        {
            if (string.IsNullOrWhiteSpace(message) == true
                || string.IsNullOrWhiteSpace(secret) == true)
            {
                return null;
            }

            var encoding = new UTF8Encoding();
            var keyByte = encoding.GetBytes(secret);
            var messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                var hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }

        private static string GetHeaderDateTime()
        {
            return DateTime.UtcNow.ToString("R");
        }

        private static string GenerateAuthenticationToken(string httpMethod, string uri, string headerDate, string publicKey, string privateKey)
        {
            var signature = string.Format("{0}|{1}|{2}", httpMethod, uri, headerDate).ToLower();
            var encryptedSignature = GenerateHmacSha256Token(signature, privateKey);
            var authorizationToken = string.Format("{0}:{1}", publicKey, encryptedSignature);
            var bytes = Encoding.UTF8.GetBytes(authorizationToken);
            return Convert.ToBase64String(bytes);
        }

        private static async Task<string> PostDocument(HttpClient client, string uri, HttpContent content)
        {
            var response = string.Empty;

            await client.PostAsync(uri, content).ContinueWith(x =>
            {
                if (x.Result.StatusCode == HttpStatusCode.OK)
                {
                    var getResponse = x.Result.Content.ReadAsStringAsync().ContinueWith(t =>
                    {
                        Console.WriteLine("Process response...");
                        var doc = XDocument.Parse(t.Result);
                        response = doc.ToString();
                    });

                    Task.WaitAll(getResponse);
                    return true;
                }

                var getFailure = x.Result.Content.ReadAsStringAsync().ContinueWith(t =>
                {
                    response = string.Format("Http Response {0}, {1}", x.Result.StatusCode, t.Result);
                });

                Task.WaitAll(getFailure);
                return false;
            });

            return response;
        }

        private HttpWebRequest GetRequest(string path, string method, string data = null)
        {
            // NOTE:  may want to review using https://github.com/restsharp/RestSharp

            var headerDate = GetHeaderDateTime();

            // the public and private key should be changed to the correct values for the rep
            var token = GenerateAuthenticationToken(method.ToLower(), path, headerDate, DefaultPublicKey, DefaultPrivateKey);

            var url = new UriBuilder(_baseUri)
            {
                Path = Path.Combine(path)
            }; // string.Format("{0}{1}", _baseUri, path);
            //Console.WriteLine(url);

            var request = (HttpWebRequest)WebRequest.Create(url.ToString());

            request.Method = method; // WebRequestMethods.Http.Get;
            // set the authorization token using the TSI custom schema
            request.Headers.Add("Authorization", $"TSI {token}");
            // set the date on the header, using X-TSI-Date because .NET does not want to set the Date header here
            request.Headers.Add("X-TSI-Date", headerDate);
            request.Accept = DefaultAcceptHeader;
            request.ContentType = DefaultAcceptHeader;

            if (method == WebRequestMethods.Http.Post)
            {
                var encoding = new UTF8Encoding();
                var postData = encoding.GetBytes(data);
                request.ContentLength = data.Length;
                request.ContentType = "application/json";
                request.GetRequestStream().Write(postData, 0, postData.Length);
            }

            return request;
        }

        /// <summary>
        /// Sample of testing user authentication.
        /// </summary>
        public ServiceOrdersPostResponse ServiceOrdersPost(ServiceOrdersPostRequest serviceOrdersPostRequest)
        {
            const string path = "/api/serviceorders";
            Console.WriteLine($"Calling endpoint at {path}...");
            try
            {
                string postData = null;

                //var serviceOrder = new ServiceOrdersPostRequest();
                string xmlPostData = null;
                // serialize to XML
                //using (var stringWriter = new StringWriter())
                //{
                //    using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
                //    {
                //        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ServiceOrdersPostRequest));
                //        xmlSerializer.Serialize(xmlWriter, serviceOrdersPostRequest);
                //        xmlPostData = stringWriter.ToString();
                //    }
                //}
                // serialize to json
                var jsonPostData = JsonConvert.SerializeObject(
                    serviceOrdersPostRequest,
                    Newtonsoft.Json.Formatting.None,
                    new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Ignore,
                        NullValueHandling = NullValueHandling.Ignore,
                    });
                //postData = xmlPostData;
                //postData = jsonPostData;
                //var encoding = new ASCIIEncoding();
                //var data = encoding.GetBytes(postData);
                var request = GetRequest(path, WebRequestMethods.Http.Post, jsonPostData);

                //request.ContentLength = data.Length;
                //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                //{
                //    //string json = "{\"user\":\"test\"," +
                //    //              "\"password\":\"bla\"}";

                //    streamWriter.Write(jsonPostData);
                //    streamWriter.Flush();
                //    streamWriter.Close();
                //}

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //WebHeaderCollection headers = response.Headers;
                    ServiceOrdersPostResponse serviceOrdersPostResponse = null;
                    using (var reader = new StreamReader(response.GetResponseStream(), ASCIIEncoding.UTF8))
                    {
                        //var responseValue = reader.ReadToEnd();
                        XmlSerializer serializer = new XmlSerializer(typeof(ServiceOrdersPostResponse));
                        serviceOrdersPostResponse = (ServiceOrdersPostResponse)serializer.Deserialize(reader);
                        reader.Close();
                    }
                    Console.WriteLine($"Call to {path} {(serviceOrdersPostResponse.Success ? "succeeded" : "failed")}: {serviceOrdersPostResponse.Message}");

                    return serviceOrdersPostResponse;
                }
                else
                {
                    Console.WriteLine($"Call to {path} responsed with status code {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Call to {path} raised exception. {ex.Message}");
            }

            return null;
        }

        /// <summary>
        /// Sample of testing user authentication.
        /// </summary>
        public AccountsPostResponse AccountsPost(AccountsPostRequest accountsPostRequest)
        {
            const string path = "/api/accounts";
            Console.WriteLine($"Calling endpoint at {path}...");
            try
            {
                // serialize to json
                var jsonPostData = JsonConvert.SerializeObject(
                    accountsPostRequest,
                    Newtonsoft.Json.Formatting.None,
                    new JsonSerializerSettings
                    {
                        DefaultValueHandling = DefaultValueHandling.Ignore,
                        NullValueHandling = NullValueHandling.Ignore,
                    });
                var request = GetRequest(path, WebRequestMethods.Http.Post, jsonPostData);
                
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //WebHeaderCollection headers = response.Headers;
                    AccountsPostResponse accountsPostResponse = null;
                    using (var reader = new StreamReader(response.GetResponseStream(), ASCIIEncoding.UTF8))
                    {
                        //var responseValue = reader.ReadToEnd();
                        XmlSerializer serializer = new XmlSerializer(typeof(AccountsPostResponse));
                        accountsPostResponse = (AccountsPostResponse)serializer.Deserialize(reader);
                        reader.Close();
                    }
                    Console.WriteLine($"Call to {path} {(accountsPostResponse.Success ? "succeeded" : "failed")}: {accountsPostResponse.Message}");

                    return accountsPostResponse;
                }
                else
                {
                    Console.WriteLine($"Call to {path} responsed with status code {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Call to {path} raised exception. {ex.Message}");
            }

            return null;
        }

        /// <summary>
        /// https://api2.tigerpawsoftware.com/docs/index#!/Diagnostics/Diagnostics_ValidateUser
        /// </summary>
        public void GetDiagnosticsValidateUser()
        {
            const string path = "/api/diagnostics/validate/user";
            try
            {
                var request = GetRequest(path, WebRequestMethods.Http.Get);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    //WebHeaderCollection headers = response.Headers;
                    DiagnosticsValidateUserResponse diagnosticsValidateUserResponse = null;
                    using (var reader = new StreamReader(response.GetResponseStream(), ASCIIEncoding.UTF8))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(DiagnosticsValidateUserResponse));
                        diagnosticsValidateUserResponse = (DiagnosticsValidateUserResponse)serializer.Deserialize(reader);
                        reader.Close();
                    }
                    Console.WriteLine($"{(diagnosticsValidateUserResponse.Success ? "A" : "Not a")}uthenticated. Message: {diagnosticsValidateUserResponse.Message}");
                }
                else
                {
                    Console.WriteLine($"Response status '{response.StatusCode}'");
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Sample of testing user authentication.
        /// </summary>
        private void UserAuthentication()
        {
            /*
            The RESTful API is secured using Http Basic authentication over an encrypted connection (TLS / SSL). 
            A unique authentication token is required for each request. 
            To generate an authentication token you will first need to generate a public and private key for a Rep.
            
            To generate the Rep's public and private key.
            Define the Rep then insert a row into the tblRepsApiUserInfo table. It is recommended to use a GUID for the public and private key.
            
            Example: Replace {RepNumber} and {User Name}
            Insert Into tblRepsApiUserInfo (RepNumber, PrivateKey, PublicKey, CreatedBy, CreatedDate, RecordStatus)
            Values({RepNumber}, newid(), newid(), {User Name}, getdate(), 1);
	    
            Select PrivateKey, PublicKey From tblRepsApiUserInfo Where RepNumber = {RepNumber}
            
            The authentication token consists of the following components {Rep’s Public Key}:{Request Signature}. 
            The Rep’s Public Key is used to identify the user making the request. 
            The Request Signature is a value generated as an alternative to a password. 
            It consists of several pieces of information about the request and is encrypted using the Rep’s private key. 
            Once the signature is created and it has been combined with the Rep’s Public Key the authentication token must be Base64 encoded. 
            When the request is received the API attempts to match the signature.

            A signature is created by combining the following {Http Method}|{URI}|{Time Stamp}. 
            Each section is separated by a vertical bar / pipe character. 
            Http Method = get, post, put, delete
            URI = URI does not include the domain or query string. Any identifiers required for the method should be included.
            Time Stamp = The time stamp should be in the RFC 1123 format. The time stamp used in the signature must match the date and time of the request headers Date or the custom X-TSI-Date header.
            The entire signature value should be converted to lowercase before it is encrypted.

            The signature string should be encrypted using the Rep’s Private Key and the HMAC-256 encryption algorithm. 
            The key and the signature string should be UTF8 encoded before encrypting. 
            After the value is encrypted the value should be Base64 encoded. 
            
            See the GenerateAuthenticationToken and GenerateHmacSha256Token methods in this example

            Signature before encryption:
            get|/api/accounts/1052932|thu, 18 jun 2015 07:25:43 gmt

            Encrypted signature:
            RVg3YCtybLImF68rEumuPLCCApLnPIyNvb0hfxH+ek4=

            Signature combined with public key:
            3383259B-9FBA-486E-97A8-E81893741F83:RVg3YCtybLImF68rEumuPLCCApLnPIyNvb0hfxH+ek4=
            
            Token:
            MzM4MzI1OUItOUZCQS00ODZFLTk3QTgtRTgxODkzNzQxRjgzOlJWZzNZQ3R5YkxJbUY2OHJFdW11UExDQ0FwTG5QSXlOdmIwaGZ4SCtlazQ9

            Set the request’s Authorization header using the Tigerpaw custom schema value and the authentication token. 
            Set the Date or the custom X-TSI-Date header on the request. The X-TSI-Date header is used when the client library does not
            support setting the standard Date header. If X-TSI-Date is provided the Date header will be ignored.

            Example with Date:
            GET http://api.tigerpawsoftware.com/api/accounts/407555 HTTP/1.1
            Authorization: TSI MzM4MzI1OUItOUZCQS00ODZFLTk3QTgtRTgxODkzNzQxRjgzOmh2UjZZQ2ZDR2lWVEovTTNNd21sRGt1YmhVOFJlV3h5TmQwZ01sSzQ4VWc9
            Date: Thu, 18 Jun 2015 08:33:51 GMT

            Example with X-TSI-Date:
            GET http://api.tigerpawsoftware.com/api/accounts/407555 HTTP/1.1
            Authorization: TSI MzM4MzI1OUItOUZCQS00ODZFLTk3QTgtRTgxODkzNzQxRjgzOmh2UjZZQ2ZDR2lWVEovTTNNd21sRGt1YmhVOFJlV3h5TmQwZ01sSzQ4VWc9
            X-TSI-Date: Thu, 18 Jun 2015 08:33:51 GMT 
             */
            Console.WriteLine("User Validation");

            var message = string.Empty;

            try
            {
                const string uri = "/api/diagnostics/validate/user";
                var headerDate = GetHeaderDateTime();
                // the public and private key should be changed to the correct values for the rep
                var token = GenerateAuthenticationToken("get", uri, headerDate, DefaultPublicKey, DefaultPrivateKey);

                var url = string.Format("{0}{1}", _baseUri, uri);
                Console.WriteLine(url);

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Get;
                // set the authorization token using the TSI custom schema
                request.Headers.Add("Authorization", string.Format("TSI {0}", token));
                // set the date on the header, using X-TSI-Date because .NET does not want to set the Date header here
                request.Headers.Add("X-TSI-Date", headerDate);
                request.Accept = DefaultAcceptHeader;
                request.ContentType = DefaultAcceptHeader;
                Console.WriteLine("Processing...");
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        Console.WriteLine("Processing Response...");

                        Console.WriteLine("Response Code: {0}", response.StatusCode);
                        switch (response.StatusCode)
                        {
                            case HttpStatusCode.OK:
                                using (var stream = response.GetResponseStream())
                                {
                                    if (stream != null)
                                    {
                                        var reader = new StreamReader(stream);
                                        var responseValue = reader.ReadToEnd();
                                        var document = XDocument.Parse(responseValue);
                                        var results = (from i in document.Descendants("Response")
                                                       let xSuccess = i.Element("Success")
                                                       let xMessage = i.Element("Message")
                                                       select new
                                                       {
                                                           Success = xSuccess != null && Convert.ToBoolean(xSuccess.Value),
                                                           Message = xMessage.Value,
                                                       }).FirstOrDefault();


                                        message = results != null ? string.Format("Authenticated: {0} {1}", results.Success, results.Success ? string.Empty : results.Message) : "Did not process response properly.";

                                    }
                                }
                                break;
                            case HttpStatusCode.Unauthorized:
                                message = "Unauthorized";
                                break;
                            default:
                                message = "Handle other status codes";
                                break;
                        }
                    }
                }

                Console.WriteLine(message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Sample of advanced search.
        /// </summary>
        private void AdvancedSearch()
        {
            try
            {
                /*
                 * AdvancedSearchRequest/Criteria is an Array
                 * Valid SearchType for  Accounts = AccountName, Address, PostalCode, Email, PhoneNumber, AccountNumber, AccountId, ExternalId, Agreement, CustomField, ContactName and ExteralProduct 
                 * Valid MatchType = StartsWith, EndsWith and Contains. If MatchType not specified defaults to StartsWith
                 * 
                 * Multiple SearchCriteria of the same SearchType become OR conditions in the example below the search is by PhoneNumber
                 * AND AccountName containing "net" OR "serv" or "sol"
                 * 
                 * CustomField search requires extra elements in SearchCriteria
                 * <SearchCriteria>
                 *     <SearchType>CustomField</SearchType>
                 *     <Criteria>1234</Criteria>
                 *     <CategoryName>Custom Category</CategoryName>
                 *     <CustomFieldName>Custom Field Name</CustomFieldName>
                 * </SearchCriteria>
                 */

                var message = string.Empty;
                const string uri = "/api/accounts/search";

                const string postData = @"<AdvancedSearchRequest>
                                  <Criteria>
                                       <SearchCriteria>
                                            <SearchType>PhoneNumber</SearchType>
                                            <Criteria>402</Criteria>
                                       </SearchCriteria>
                                       <SearchCriteria>
                                            <SearchType>AccountName</SearchType>
                                            <MatchType>Contains</MatchType>
                                            <Criteria>net</Criteria>
                                       </SearchCriteria>
                                       <SearchCriteria>
                                            <SearchType>AccountName</SearchType>
                                            <MatchType>Contains</MatchType>
                                            <Criteria>serv</Criteria>
                                       </SearchCriteria> 
                                       <SearchCriteria>
                                            <SearchType>AccountName</SearchType>
                                            <MatchType>Contains</MatchType>
                                            <Criteria>sol</Criteria>
                                       </SearchCriteria> 
                                  </Criteria>
                                  <PageSize>10</PageSize>
                                </AdvancedSearchRequest>";

                Console.WriteLine("Advanced Search");

                var encoding = new UTF8Encoding();
                var data = encoding.GetBytes(postData);

                var headerDate = GetHeaderDateTime();
                // the public and private key should be changed to the correct values for the rep
                var token = GenerateAuthenticationToken("post", uri, headerDate, DefaultPublicKey, DefaultPrivateKey);

                var url = string.Format("{0}{1}", _baseUri, uri);
                Console.WriteLine(url);

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Post;
                request.Headers.Add("Authorization", string.Format("TSI {0}", token));
                request.Headers.Add("X-TSI-Date", headerDate);
                request.Accept = DefaultAcceptHeader;
                request.ContentType = DefaultAcceptHeader;
                request.ContentLength = data.Length;
                request.GetRequestStream().Write(data, 0, data.Length);

                Console.WriteLine("Processing...");
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        Console.WriteLine("Response Code: {0}", response.StatusCode);
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            Console.WriteLine("Processing Response...");
                            using (var stream = response.GetResponseStream())
                            {
                                if (stream != null)
                                {
                                    var reader = new StreamReader(stream);
                                    var responseValue = reader.ReadToEnd();
                                    var document = XDocument.Parse(responseValue);

                                    if (document.Root != null)
                                    {
                                        var decendants = document.Descendants("SearchAccountResponse");
                                        var results = (from i in decendants
                                                       let xSuccess = i.Element("Success")
                                                       let xTotalCount = i.Element("TotalCount")
                                                       let xPageSize = i.Element("PageSize")
                                                       let xNextRow = i.Element("NextRow")
                                                       select new
                                                       {
                                                           Success = xSuccess != null && Convert.ToBoolean(xSuccess.Value),
                                                           TotalCount = Convert.ToInt32(xTotalCount.Value),
                                                           PageSize = Convert.ToInt32(xPageSize.Value),
                                                           NextRow = Convert.ToInt32(xNextRow.Value)
                                                       }).FirstOrDefault();


                                        if (results != null
                                            && results.Success == true)
                                        {
                                            message = string.Format("Matching accounts {0}", results.TotalCount);

                                            var currentPage = document.Descendants("AccountSummary");
                                            currentPage.ToList().ForEach(PrintAccountName);
                                        }
                                        else
                                        {
                                            message = "Did not process response properly.";
                                        }
                                    }
                                    else
                                    {
                                        message = "No document root found.";
                                    }
                                }
                            }
                        }
                        else
                        {
                            message = "Evaluate response code for more detailed error...";
                        }
                    }


                }

                Console.WriteLine(message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// POST /api/serviceorders/search/reference
        /// </summary>
        public Models.TigerPaw.Responses.ServiceOrderSearchResponse ServiceOrderSearchByReference(string reference, int pageSize = 1, int pageStart = 1)
        {
            try
            {
                var message = string.Empty;
                const string uri = "/api/serviceorders/search/reference";

                string postData = $@"<Criteria>{reference}</Criteria>";

                Console.WriteLine("Advanced Search");

                var encoding = new UTF8Encoding();
                var data = encoding.GetBytes(postData);

                var headerDate = GetHeaderDateTime();
                // the public and private key should be changed to the correct values for the rep
                var token = GenerateAuthenticationToken("post", uri, headerDate, DefaultPublicKey, DefaultPrivateKey);

                //var url = string.Format("{0}{1}", BaseUri, uri);
                var url = new UriBuilder(_baseUri);
                url.Path = uri;
                var queryParameters = HttpUtility.ParseQueryString(string.Empty);
                //queryParameters["criteria"] = reference;
                queryParameters["pageSize"] = pageSize.ToString();
                queryParameters["startRow"] = pageStart.ToString();
                url.Query = queryParameters.ToString();
                Console.WriteLine(url);

                var request = (HttpWebRequest)WebRequest.Create(url.ToString());
                request.Method = WebRequestMethods.Http.Post;
                request.Headers.Add("Authorization", string.Format("TSI {0}", token));
                request.Headers.Add("X-TSI-Date", headerDate);
                request.Accept = DefaultAcceptHeader;
                request.ContentType = DefaultAcceptHeader;
                request.ContentLength = data.Length;
                request.GetRequestStream().Write(data, 0, data.Length);

                Console.WriteLine("Processing...");
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        Console.WriteLine("Response Code: {0}", response.StatusCode);
                        if (response.StatusCode == HttpStatusCode.OK)
                        {

                            // TODO:  can we deserialize this response to a response model object/type ???

                            return new Models.TigerPaw.Responses.ServiceOrderSearchResponse();

                            Console.WriteLine("Processing Response...");
                            using (var stream = response.GetResponseStream())
                            {
                                if (stream != null)
                                {
                                    var reader = new StreamReader(stream);
                                    var responseValue = reader.ReadToEnd();
                                    var document = XDocument.Parse(responseValue);

                                    if (document.Root != null)
                                    {
                                        var decendants = document.Descendants("SearchAccountResponse");
                                        var results = (from i in decendants
                                                       let xSuccess = i.Element("Success")
                                                       let xTotalCount = i.Element("TotalCount")
                                                       let xPageSize = i.Element("PageSize")
                                                       let xNextRow = i.Element("NextRow")
                                                       select new
                                                       {
                                                           Success = xSuccess != null && Convert.ToBoolean(xSuccess.Value),
                                                           TotalCount = Convert.ToInt32(xTotalCount.Value),
                                                           PageSize = Convert.ToInt32(xPageSize.Value),
                                                           NextRow = Convert.ToInt32(xNextRow.Value)
                                                       }).FirstOrDefault();


                                        if (results != null
                                            && results.Success == true)
                                        {
                                            message = string.Format("Matching accounts {0}", results.TotalCount);

                                            var currentPage = document.Descendants("AccountSummary");
                                            currentPage.ToList().ForEach(PrintAccountName);
                                        }
                                        else
                                        {
                                            message = "Did not process response properly.";
                                        }
                                    }
                                    else
                                    {
                                        message = "No document root found.";
                                    }
                                }
                            }
                        }
                        else
                        {
                            message = "Evaluate response code for more detailed error...";
                        }
                    }


                }

                Console.WriteLine(message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            return null;
        }

        /// <summary>
        /// Get documents attached to an existing opportunity.
        /// </summary>
        private void OpportunityDocuments()
        {
            Console.WriteLine("User Validation");

            var message = string.Empty;

            try
            {
                // replace the opportunity number
                const int opportunityNumber = 13074;
                var uri = string.Format("/api/opportunities/{0}/documents", opportunityNumber);
                var headerDate = GetHeaderDateTime();
                // the public and private key should be changed to the correct values for the rep
                var token = GenerateAuthenticationToken("get", uri, headerDate, DefaultPublicKey, DefaultPrivateKey);

                var url = string.Format("{0}{1}", _baseUri, uri);
                Console.WriteLine(url);

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = WebRequestMethods.Http.Get;
                // set the authorization token using the TSI custom schema
                request.Headers.Add("Authorization", string.Format("TSI {0}", token));
                // set the date on the header, using X-TSI-Date because .NET does not want to set the Date header here
                request.Headers.Add("X-TSI-Date", headerDate);
                request.Accept = DefaultAcceptHeader;
                request.ContentType = DefaultAcceptHeader;
                Console.WriteLine("Processing...");
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    if (response != null)
                    {
                        Console.WriteLine("Processing Response...");

                        Console.WriteLine("Response Code: {0}", response.StatusCode);
                        switch (response.StatusCode)
                        {
                            case HttpStatusCode.OK:
                                using (var stream = response.GetResponseStream())
                                {
                                    if (stream != null)
                                    {
                                        var reader = new StreamReader(stream);
                                        var responseValue = reader.ReadToEnd();
                                        var document = XDocument.Parse(responseValue);
                                        var results = (from i in document.Descendants("DocumentsResponse")
                                                       let xSuccess = i.Element("Success")
                                                       let xTotalCount = i.Element("TotalCount")
                                                       let xPageSize = i.Element("PageSize")
                                                       let xNextRow = i.Element("NextRow")
                                                       select new
                                                       {
                                                           Success = xSuccess != null && Convert.ToBoolean(xSuccess.Value),
                                                           TotalCount = Convert.ToInt32(xTotalCount.Value),
                                                           PageSize = Convert.ToInt32(xPageSize.Value),
                                                           NextRow = Convert.ToInt32(xNextRow.Value)
                                                       }).FirstOrDefault();


                                        if (results != null
                                            && results.Success == true)
                                        {
                                            message = string.Format("Documents found {0}", results.TotalCount);

                                            var currentPage = document.Descendants("DocumentSummary");
                                            currentPage.ToList().ForEach(PrintDocumentTitle);
                                        }
                                        else
                                        {
                                            message = "Did not process response properly.";
                                        }

                                    }
                                }
                                break;
                            default:
                                message = "Handle other status codes";
                                break;
                        }
                    }
                }

                Console.WriteLine(message);
                Console.ReadLine();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Attaches a document to an opportunity.
        /// </summary>
        private async void AttachDocumentToOpportunity()
        {
            /*
             * Note that for the DocumentModel the Topic must be a valid document topic from the master table.
             * After the document has been attached there are separate REST methods to update the Tigerpaw database and update the physical file
             * Update Tigerpaw database attributes for an attached file = PUT api/opportunities/13074/documents/3517
             * Overwrite bytes of physical file = PUT api/opportunities/13074/documents/3517/overwrite
             * - To overwrite the request would be formatted like the create without the document model (string content)
             * Rename physical file = PUT api/opportunities/13074/documents/3517/rename
             * - Simple put request with new name as string in the request body
             */
            var message = "message dropped before set";

            const string path = @"C:\Users\tmartin\Desktop\Reading\Test Document.pdf";
            const string fileName = "Test Document.pdf";
            const int opportunityNumber = 13074;
            // this is the xml string that is posted with the information about the document
            const string documentModel = @"<DocumentModel><Description>Document Description</Description><DisplayInPortal>true</DisplayInPortal><FileName>Test Document.pdf</FileName><Title>Title of Document</Title><Topic>Opportunity</Topic></DocumentModel>";

            try
            {
                var uri = string.Format("/api/opportunities/{0}/documents", opportunityNumber);
                var headerDate = GetHeaderDateTime();
                // the public and private key should be changed to the correct values for the rep
                var token = GenerateAuthenticationToken("post", uri, headerDate, DefaultPublicKey, DefaultPrivateKey);
                var authorization = new AuthenticationHeaderValue("TSI", token);
                var url = string.Format("{0}{1}", _baseUri, uri);


                Console.WriteLine(url);

                Console.WriteLine("Processing...");
                using (var client = new HttpClient())
                {
                    Console.WriteLine("Starting Task...");
                    client.BaseAddress = new Uri(_baseUri);
                    client.DefaultRequestHeaders.Add("X-TSI-Date", headerDate);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                    client.DefaultRequestHeaders.Authorization = authorization;

                    Console.WriteLine("Creating Content...");

                    var content = new MultipartFormDataContent(Guid.NewGuid().ToString());
                    var stringContent = new StringContent(documentModel);
                    stringContent.Headers.Add("Content-Disposition", "form-data; name=\"uploadfile\"");

                    var fs = File.OpenRead(path);
                    var streamContent = new StreamContent(fs);
                    //var contentType = MimeMapping.GetMimeMapping(Path.GetExtension(fileName)); // old way
                    var contentType = GetMimeMapping(Path.GetExtension(fileName));
                    streamContent.Headers.Add("Content-Type", contentType);
                    streamContent.Headers.Add("Content-Disposition",
                        string.Format("form-data; name=\"file\"; filename=\"{0}\"", fileName));

                    content.Add(stringContent, "uploadfile");
                    content.Add(streamContent, "file", fileName);

                    Console.WriteLine("Posting...");

                    //message = PostDocument(client, uri, content).Result;
                    message = await PostDocument(client, uri, content);

                }
            }
            catch (AggregateException ax)
            {
                ax.Handle((x) =>
                {
                    message += x.Message;
                    return true;
                });
            }
            catch (Exception ex)
            {
                message += ex.Message;
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }

        
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        UserAuthentication();

        //        //AdvancedSearch();

        //        //OpportunityDocuments();

        //        //AttachDocumentToOpportunity();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.ReadLine();
        //    }
        //}

        private static string GetMimeMapping(string fileName)
        {
            var provider = new Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider();
            string contentType;
            if (!provider.TryGetContentType(fileName, out contentType))
            {
                contentType = "application/octet-stream";
            }
            return contentType;
        }

        public Models.TigerPaw.ServiceOrdersPostResponse CreateServiceOrderWithPartsUsed(Quote quote, List<QuoteItem> partsUsed)
        {
            // create service order via POST /api/ServiceOrders CreateServiceOrderModel ServiceOrderResponse
            var serviceOrder = CreateServiceOrderFromQuote(quote);
            // if response is not successful or no ServiceOrder number is returned
            if (serviceOrder == null)
            {
                throw new ApplicationException($"Failed to create new service order for quote {quote.Name}");
            }
            // for each part/item, via POST /api/serviceorders/{serviceOrderNumber}/parts
            foreach (object part in partsUsed)
            {
                CreateServiceOrderPartsUsed(serviceOrder.ServiceOrderSummary.ServiceOrderNumber, part);
            }
            return serviceOrder;
        }

        private Models.TigerPaw.ServiceOrdersPostResponse CreateServiceOrderFromQuote(Quote quote)
        {
            // todo: create service order with reference
            return new Models.TigerPaw.ServiceOrdersPostResponse();
        }

        private Models.TigerPaw.ServiceOrderPartsUsedResponse CreateServiceOrderPartsUsed(int serviceOrderNumber, object part)
        {
            // todo!
            return new Models.TigerPaw.ServiceOrderPartsUsedResponse();
        }

        private Models.TigerPaw.Responses.GetServiceOrderResponse GetServiceOrder(int serviceOrderNumber)
        {
            // GET /api/serviceorders/{serviceOrderNumber}

            return new Models.TigerPaw.Responses.GetServiceOrderResponse();
        }

        public bool ServiceOrderExists(int serviceOrderNumber)
        {
            return GetServiceOrder(serviceOrderNumber) != null;
        }
        
        public bool ServiceOrderExistsWithReferenceToQuote(string quoteNumber)
        {
            return ServiceOrderSearchByReference(quoteNumber).TotalCount > 0;
        }

        //public List<Models.TigerPaw.Responses.ServiceOrder> ServiceOrderSearchByReference(string reference, int pageSize = 1, int pageStart = 1)
        //{
        //    return new Models.TigerPaw.Responses.ServiceOrderSearchResponse().ServiceOrders.Where(p => p.Reference.Contains(reference)).ToList();
        //}

    }
}