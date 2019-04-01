using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblCurrentQuoteId
    {
        public int? QuoteId { get; set; }
        public bool? Recalc { get; set; }
        public int CurrentQuoteId { get; set; }
    }
}
