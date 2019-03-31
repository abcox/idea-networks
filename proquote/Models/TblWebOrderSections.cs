using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblWebOrderSections
    {
        public int SectionId { get; set; }
        public int? QuoteId { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Footer { get; set; }
        public bool? IncludeInTotal { get; set; }
        public int? OrderId { get; set; }
        public bool? ShowItemPricing { get; set; }
        public bool? ShowSectionTotal { get; set; }
        public bool? ShowSectionHeader { get; set; }
        public bool? ShowSectionFooter { get; set; }
        public bool? IsOnNewPage { get; set; }
        public bool? Hide { get; set; }
        public bool? Locked { get; set; }
        public bool? ShowAfterGrandTotal { get; set; }
        public int? OldSectionId { get; set; }
        public int? OldParentId { get; set; }
        public byte[] Ts { get; set; }
    }
}
