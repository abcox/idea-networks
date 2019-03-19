using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace test.Models.TigerPaw.Responses
{
    //[Serializable()]
    [XmlRoot(
        //Namespace = "www.contoso.com",
        ElementName = "Response",
        DataType = "string",
        IsNullable = true
        )]
    public class DiagnosticsValidateUserResponse
    {
        [System.Xml.Serialization.XmlElement("Success")]
        public bool Success { get; set; }

        [System.Xml.Serialization.XmlElement("Message")]
        public string Message { get; set; }
    }


}
