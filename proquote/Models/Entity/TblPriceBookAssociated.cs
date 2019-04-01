using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblPriceBookAssociated
    {
        public int AssociatedId { get; set; }
        public string PartNumber { get; set; }
        public string AssociatedPartNumber { get; set; }
        public string GroupName { get; set; }
        public int? OrderId { get; set; }
        public string AssocType { get; set; }
        public string SectionName { get; set; }
        public int? SectionOrder { get; set; }
        public int? GroupOrder { get; set; }
        public string OptionPartNumber { get; set; }
        public int? OptionSortId { get; set; }
        public string SubComponentName { get; set; }
        public int? SubComponentOrder { get; set; }
    }
}
