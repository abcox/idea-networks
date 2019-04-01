using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblPriceBookSearchFields
    {
        public int SearchFieldId { get; set; }
        public string Name { get; set; }
        public string Sqlname { get; set; }
        public string Type { get; set; }
        public string SearchFor { get; set; }
        public string ReplaceWith { get; set; }
    }
}
