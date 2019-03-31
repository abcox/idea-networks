using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblConstraints
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string AssociatedPartNumber { get; set; }
        public string GroupName { get; set; }
        public int? ItemOrderId { get; set; }
        public int? GroupOrderId { get; set; }
        public string CantGoWith { get; set; }
        public string MustGoWith { get; set; }
        public bool? IsRequired { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public string Instructions { get; set; }
    }
}
