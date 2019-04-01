using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblQuoteConfigurations
    {
        public int ConfigId { get; set; }
        public int QuoteId { get; set; }
        public string ConfigPartNumber { get; set; }
        public string ConfigDescription { get; set; }
    }
}
