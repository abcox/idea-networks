using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteFieldsLookup
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public string TableName { get; set; }
        public string FieldFormName { get; set; }
        public string FieldParentFormName { get; set; }
        public string ControlValue { get; set; }
        public byte[] Ts { get; set; }
    }
}
