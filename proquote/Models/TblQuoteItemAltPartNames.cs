using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteItemAltPartNames
    {
        public int QuoteItemAlternateId { get; set; }
        public int? QuoteItemId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPartNumber { get; set; }
    }
}
