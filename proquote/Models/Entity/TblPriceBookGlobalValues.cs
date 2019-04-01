using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblPriceBookGlobalValues
    {
        public int GlobalValueId { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
    }
}
