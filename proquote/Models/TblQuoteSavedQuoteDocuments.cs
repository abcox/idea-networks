using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteSavedQuoteDocuments
    {
        public int SavedQuoteDocumentId { get; set; }
        public string DocField { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string DocTitle { get; set; }
    }
}
