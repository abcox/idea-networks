using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteDatabaseUsers
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string FullName { get; set; }
        public string DefaultReport { get; set; }
        public string WebDefaultReport { get; set; }
        public string WebReportpath { get; set; }
        public string DefaultFilter { get; set; }
        public string Password { get; set; }
        public string CompanyName { get; set; }
        public string UserCode { get; set; }
        public string UserTitle { get; set; }
        public string UserAddress { get; set; }
        public string UserPhone { get; set; }
        public string UserFax { get; set; }
        public string UserEmail { get; set; }
        public string UserType { get; set; }
        public string UserRegion { get; set; }
        public string Groups { get; set; }
        public string PreQueryFilter { get; set; }
        public string ArchivesFilePath { get; set; }
        public string QuotePrefix { get; set; }
        public string StartQuoteNumber { get; set; }
        public string EndQuoteNumber { get; set; }
        public string ImportFilepath { get; set; }
        public string ExportFilePath { get; set; }
        public string SyncGroup { get; set; }
        public bool? WebAccessAllowed { get; set; }
        public string SalesGroup { get; set; }
        public string ProductsGroup { get; set; }
        public string Region { get; set; }
        public string SignatureFile { get; set; }
        public int? MaxRecInGrid { get; set; }
        public int? MaxRecInFilter { get; set; }
        public string QuoteListSort { get; set; }
        public string UserMobile { get; set; }
    }
}
