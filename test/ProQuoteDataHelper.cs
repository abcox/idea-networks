using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class ProQuoteDataHelper
    {
        public static Quote GetQuote(string quoteNumber)
        {
            return new Quote();
        }

        public static List<QuotePart> GetPartsByQuoteNumber(string quoteNumber)
        {
            // todo:  query parts from db
            return new List<QuotePart>();
        }
    }

    class QuotePart
    {
        public int number { get; set; }
    }

    class Quote
    {
        public int number { get; set; }
    }
}
