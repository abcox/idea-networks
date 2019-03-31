using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class ArchTblQuoteStatus
    {
        public int ArchStatusId { get; set; }
        public string QuoteName { get; set; }
        public int? StatusId { get; set; }
        public int? QuoteId { get; set; }
        public string Status { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string Reason { get; set; }
    }
}
