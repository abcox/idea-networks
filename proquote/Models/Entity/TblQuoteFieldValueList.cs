using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblQuoteFieldValueList
    {
        public int Id { get; set; }
        public string ControlName { get; set; }
        public string TableName { get; set; }
        public string ControlFormName { get; set; }
        public string ControlParentFormName { get; set; }
        public string ControlValueList { get; set; }
        public string ControlValueSql { get; set; }
    }
}
