using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace test
{
    class Program
    {
        private static IConfiguration _config;

        static void Main(string[] args)
        {
            var config = ConfigurationHelper.Configuration;
            var storageConnectionString = config.GetConnectionString("ProQuote");
            var privateKey = config.GetSection("PrivateKey").Value;
            var publicKey = config.GetSection("PublicKey").Value;

            //Console.WriteLine($"PublicKey: {publicKey}, PrivateKey: {privateKey}");

            var tpApi = new TigerPawApiHelper(privateKey, publicKey);  // unauthorized (401)

            // todo:  parse args and validate, if none or badly formed (invalid), then present command useage

            // todo:  validate request

            string quoteName = null;
            if (args.Length > 0) quoteName = args[0];

            // todo: lookup this quoteNumber in ProQuote (table) ?
            var quote = ProQuoteDataHelper.GetQuote(quoteName);
            if (quote == null)
            {
                var msg = $"Quote with name {quoteName} not found.";
                //throw new ApplicationException(msg);
                Console.WriteLine(msg);
                Environment.Exit(-1);
            }

            Console.WriteLine($"Quote '{quote.name}' found");

            var serviceOrders = tpApi.ServiceOrderSearchByReference(quoteName);
            if (serviceOrders?.TotalCount > 0)
            {
                throw new ApplicationException($"A service order with number {serviceOrders} exists with quote '{quoteName}'");
            }

            // TODO: get service order parts from ProQuote manifest
            var parts = ProQuoteDataHelper.GetPartsByQuoteName(quoteName);

            // TODO: create the service order with parts
            var partsDto = new List<QuotePart>();
            var serviceOrder = tpApi.CreateServiceOrderWithPartsUsed(quote, partsDto);

            Console.ReadLine();
        }

    }
}
