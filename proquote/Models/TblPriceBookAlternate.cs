using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblPriceBookAlternate
    {
        public int AlternatePartId { get; set; }
        public string PartNumber { get; set; }
        public string CustomerPartNumber { get; set; }
        public string CustomerName { get; set; }
    }
}
