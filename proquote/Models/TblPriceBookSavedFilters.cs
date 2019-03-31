using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblPriceBookSavedFilters
    {
        public int FilterId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public string Sqlname { get; set; }
        public string SearchFor { get; set; }
        public string ReplaceWith { get; set; }
        public bool? PrivateFilter { get; set; }
    }
}
