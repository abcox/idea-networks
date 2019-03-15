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

            string quoteNumber = null;
            if (args.Length > 0) quoteNumber = args[1];

            // todo: lookup this quoteNumber in ProQuote (table) ?
            var quote = ProQuoteDataHelper.GetQuote(quoteNumber);
            if (quote == null)
            {
                throw new ApplicationException($"Quote with number {quoteNumber} not found.");
            }

            var serviceOrders = tpApi.ServiceOrderSearchByReference(quoteNumber);
            if (serviceOrders?.TotalCount > 0)
            {
                throw new ApplicationException($"A service order with number {serviceOrders} exists with reference '{quoteNumber}'");
            }

            // TODO: get service order parts from ProQuote manifest
            var parts = ProQuoteDataHelper.GetPartsByQuoteNumber(quoteNumber);

            // TODO: create the service order with parts
            var partsDto = new List<QuotePart>();
            var serviceOrder = tpApi.CreateServiceOrderWithPartsUsed(quote, partsDto);
        }

    }
}
