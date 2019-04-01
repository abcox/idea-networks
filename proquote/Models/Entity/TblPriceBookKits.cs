using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblPriceBookKits
    {
        public int PriceBookKitId { get; set; }
        public double? Quantity { get; set; }
        public string PartNumber { get; set; }
        public string ChildPartNumber { get; set; }
    }
}
