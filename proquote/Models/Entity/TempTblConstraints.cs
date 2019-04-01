using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TempTblConstraints
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? UniqueId { get; set; }
        public string PartNumber { get; set; }
        public string AssociatedPartNumber { get; set; }
        public string GroupName { get; set; }
        public int? ItemOrderId { get; set; }
        public string CantGoWith { get; set; }
        public string MustGoWith { get; set; }
        public bool? IsRequired { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public string Instructions { get; set; }
        public string OptionType { get; set; }
        public string BundleName { get; set; }
        public string OptionName { get; set; }
        public bool? IsBaseModel { get; set; }
        public string StdPartNumber1 { get; set; }
        public string NonePartNumber { get; set; }
        public bool? IsNone { get; set; }
        public string System { get; set; }
        public string SubSystem { get; set; }
        public string SectionName { get; set; }
        public int? SectionOrderId { get; set; }
        public bool? QtyEnabled { get; set; }
        public int? Quantity { get; set; }
    }
}
