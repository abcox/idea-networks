using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblFormSettings
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnWidth { get; set; }
        public int? ColumnOrder { get; set; }
        public string UserName { get; set; }
        public string ParentForm { get; set; }
        public int? Rowheight { get; set; }
        public bool IsFrozen { get; set; }
    }
}
