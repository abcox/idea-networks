using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using test.Models.ProQuote;
using test.Models.TigerPaw;
using Tsi.Web.Api;
using Tsi.Web.Model;

namespace test
{
    class Program
    {
        //private static IConfiguration _config;

        static void Main(string[] args)
        {
            var config = new ConfigurationHelper();
            var storageConnectionString = config.ProQuoteConnectionString; //.GetConnectionString("ProQuote");
                                                                           //string tsiApiEnvironment = "tsiApi_sand";
#if DEBUG
            config.EnvironmentSelected = ConfigurationHelper.Environment.Sandbox;
#else
            //tsiApiEnvironment = "tsiApi_prod";
            config.EnvironmentSelected = ConfigurationHelper.Environment.Production;
#endif
            var apiBaseUrl = config.ApiBaseUrl; // config.GetSection($"{tsiApiEnvironment}:serviceUrl").Value;
            var apiPrivateKey = config.ApiPrivateKey; // config.GetSection($"{tsiApiEnvironment}:privateKey").Value;
            var apiPublicKey = config.ApiPublicKey; // config.GetSection($"{tsiApiEnvironment}:publicKey").Value;

            //Console.WriteLine($"PublicKey: {publicKey}, PrivateKey: {privateKey}");

            var tpApi = new TigerPawApiHelper(
                serviceUrl: apiBaseUrl,
                privateKey: apiPrivateKey,
                publicKey: apiPublicKey
                );  // unauthorized (401)

            // instance
            var instance = new ServiceOrdersApi(new Tsi.Web.Client.Configuration(
                apiKeyPrefix: null,
                apiKey: new Dictionary<string, string> {
                    { "private", config.ApiPrivateKey },
                    { "public", config.ApiPublicKey }
                },
                basePath: config.ApiBaseUrl,
                defaultHeader: null // TODO: is this where we can create header as required (via method calls)
                )
            );

            // configure request
            int? serviceOrderNumber = 80280;
            TsiWebCreateServiceOrderPartsUsedModel model = new TsiWebCreateServiceOrderPartsUsedModel
                (
                lineNumber: 1, // Note: existing line item will be pushed down
                               //itemId: "Cat 6 RJ45 insert",
                priceBookItemNumber: 97, // look up via PriceBookSearchByItemTypeTest
                itemDescription: "Cat 6 RJ45 insert",
                useBookPricesAndDiscounts: true,
                quantity: 3
                );

            // call api
            var response = instance.ServiceOrdersCreateServiceOrderPartsUsed(serviceOrderNumber, model);

            // todo:  parse args and validate, if none or badly formed (invalid), then present command useage

            // todo:  validate request

            // user authentication check
            //tpApi.GetDiagnosticsValidateUser();  // the old way!

            var id = Guid.NewGuid();

            // TEST ServiceOrdersPost
            //var accounts = new AccountsPostRequest()
            //{
            //    Account = new Account
            //    {
            //        Name = $"Test account {id}",
            //        RepNumber = 68,
            //        Status = "Active",
            //        AccountType = "Prospect",
            //    },
            //    PrimaryPhoneNumber = new PrimaryPhoneNumber
            //    {
            //        Number = "555-1234",
            //    }
            //};
            var accountNumber = 10177;
            var accountsPostResponse = new AccountsPostResponse { Success = true };
            //accountsPostResponse = tpApi.AccountsPost(accounts);
            //accountNumber = accountsPostResponse.AccountSummary?.AccountNumber ?? 0;
            //Console.WriteLine($"Service order post {(accountsPostResponse.Success ? "succeeded" : "failed")}. Number: {accountNumber}");

            // TEST ServiceOrdersPost
            if (accountsPostResponse.Success)
            {
                var serviceOrder = new ServiceOrdersPostRequest()
                {
                    AccountNumber = accountNumber,
                    BriefDescription = $@"TEST {id}", // 8c972fea-5327-4ecf-b113-fca8bc09a3cb
                    DateTimeRequested = new DateTimeRequested
                    {
                        Date = DateTime.UtcNow,
                        Time = DateTime.UtcNow,
                    },
                    BillToAddressType = "Default",
                    BillTo = new BillTo
                    {
                        Name = "Test!",
                        Address1 = "12345 Main St",
                        City = "Wilmington",
                        State = "NC",
                        PostalCode = "28403"
                    }
                };
                var serviceOrdersPostResponse = tpApi.ServiceOrdersPost(serviceOrder);
                Console.WriteLine($"Service order post {(serviceOrdersPostResponse.Success ? "succeeded" : "failed")}. AccountNumber: {serviceOrdersPostResponse.ServiceOrderSummary?.ServiceOrder?.AccountNumber}");
            }

            // TEST dapper pull of quotes
            List<Quote> quotes = null;
            try
            {
                quotes = new ProQuoteDataHelper().GetQuotes();
                Console.Write($"Quote count = {quotes.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:  {ex.Message}");
            }

            string quoteName = null;
            if (args.Length > 0) quoteName = args[0];

            // todo: lookup this quoteNumber in ProQuote (table) ?
            var quote = new ProQuoteDataHelper().GetQuote(quoteName);
            if (quote == null)
            {
                var msg = $"Quote with name {quoteName} not found.";
                //throw new ApplicationException(msg);
                Console.WriteLine(msg);
                Environment.Exit(-1);
            }

            string quoteNumber = "55131.17";
            var results = new ProQuoteDataHelper().GetQuote_JobOpen_Quote_BillTo(quoteNumber);
            foreach (var item in results)
            {
                Console.WriteLine($"Quote name '{item.QuoteName}'");
            }


            Console.WriteLine($"Quote '{quote.Name}' found");

            var serviceOrders = tpApi.ServiceOrderSearchByReference(quoteName);
            if (serviceOrders?.TotalCount > 0)
            {
                throw new ApplicationException($"A service order with number {serviceOrders} exists with quote '{quoteName}'");
            }

            // TODO: get service order parts from ProQuote manifest
            var parts = ProQuoteDataHelper.GetPartsByQuoteName(quoteName);

            // TODO: create the service order with parts
            var partsDto = new List<QuoteItem>();
            //var serviceOrder = tpApi.CreateServiceOrderWithPartsUsed(quote, partsDto);

            Console.ReadLine();
        }

    }
}
