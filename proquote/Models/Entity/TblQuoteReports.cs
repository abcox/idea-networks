using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblQuoteReports
    {
        public int ReportId { get; set; }
        public string Name { get; set; }
        public string ReportName { get; set; }
        public string SubFormName { get; set; }
        public string OptionsUsed { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string Groups { get; set; }
        public bool? Show { get; set; }
        public string Reportpath { get; set; }
        public bool Use { get; set; }
        public bool EmailPdf { get; set; }
        public string FormPath { get; set; }
        public bool IsWebReport { get; set; }
        public bool BatchReport { get; set; }
        public string BatchName { get; set; }
    }
}
