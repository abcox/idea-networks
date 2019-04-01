using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblPriceBookImportSpecs
    {
        public int ImportSpecId { get; set; }
        public string SelectedFields { get; set; }
        public string ImportExport { get; set; }
        public string TableType { get; set; }
        public string FileName { get; set; }
        public string TableName { get; set; }
        public string HasFieldNames { get; set; }
        public string Range { get; set; }
        public int? DefaultSection { get; set; }
        public int? DefaultSubSection { get; set; }
        public string Fullpath { get; set; }
        public bool? AddParts { get; set; }
        public bool? UpdateParts { get; set; }
        public string SpecName { get; set; }
    }
}
