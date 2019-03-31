using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class ArchTblQuoteDocuments
    {
        public int ArchDocsId { get; set; }
        public string QuoteName { get; set; }
        public int? QuoteDocumentId { get; set; }
        public int? QuoteId { get; set; }
        public string Type { get; set; }
        public string DocName { get; set; }
        public string DocPath { get; set; }
        public string Description { get; set; }
        public bool? PrintDoc { get; set; }
        public bool? IsPriceBook { get; set; }
    }
}
