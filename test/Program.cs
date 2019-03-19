using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using test.Models.ProQuote;

namespace test
{
    class Program
    {
        //private static IConfiguration _config;

        static void Main(string[] args)
        {
            var config = ConfigurationHelper.Configuration;
            var storageConnectionString = config.GetConnectionString("ProQuote");
            var tsiApiEnvironment = "tsiApi_prod";
            var serviceUrl = config.GetSection($"{tsiApiEnvironment}:serviceUrl").Value;
            var privateKey = config.GetSection($"{tsiApiEnvironment}:privateKey").Value;
            var publicKey = config.GetSection($"{tsiApiEnvironment}:publicKey").Value;

            //Console.WriteLine($"PublicKey: {publicKey}, PrivateKey: {privateKey}");

            var tpApi = new TigerPawApiHelper(
                serviceUrl: serviceUrl,
                privateKey: privateKey,
                publicKey: publicKey
                );  // unauthorized (401)

            // todo:  parse args and validate, if none or badly formed (invalid), then present command useage

            // todo:  validate request

            // TEST dapper pull of quotes
            List<Quote> quotes = null;
            try
            {
                quotes = ProQuoteDataHelper.GetQuotes();
                Console.Write($"Quote count = {quotes.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred:  {ex.Message}");
            }

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
            var serviceOrder = tpApi.CreateServiceOrderWithPartsUsed(quote, partsDto);

            Console.ReadLine();
        }

    }
}
