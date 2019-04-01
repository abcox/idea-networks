using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblQuoteDatabaseProperties
    {
        public int PropertiesId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Description { get; set; }
        public string StatusLevels { get; set; }
        public string DefaultStatus { get; set; }
        public string RevisionStatus { get; set; }
        public string IssueStatus { get; set; }
        public string Prefix { get; set; }
        public int? NumberLength { get; set; }
        public int? ExtensionLength { get; set; }
        public string OrderStatus { get; set; }
        public string ExpiredStatus { get; set; }
        public string DefTerms { get; set; }
        public string DefQuoteHeader { get; set; }
        public string DefQuoteFooter { get; set; }
        public string DefCoverLetter { get; set; }
        public string DefFaxLetter { get; set; }
        public string OrderTableName { get; set; }
        public string OrderTableType { get; set; }
        public string OrderTableLocation { get; set; }
        public string InventoryTableName { get; set; }
        public string InventoryTableType { get; set; }
        public string InventoryTableLocation { get; set; }
        public string RoundingEnabled { get; set; }
        public string DefHeaderTitle { get; set; }
        public string DefFaxTitle { get; set; }
        public string DefFooterTitle { get; set; }
        public string DefTermsTitle { get; set; }
        public string DefCoverTitle { get; set; }
        public int? DefIssuedDate { get; set; }
        public int? DefAwardDate { get; set; }
        public int? DefExpiryDate { get; set; }
        public int? DefReqdDate { get; set; }
        public string ImagePath { get; set; }
        public string DocPath { get; set; }
        public string Smtp { get; set; }
        public int? SmtpPort { get; set; }
        public bool? SmtpUseCredentials { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public bool? IsSystemVersion { get; set; }
        public string SectionBaseSystem { get; set; }
        public string SectionAdditionOptions { get; set; }
        public string SectionNonIncludedOptions { get; set; }
        public string Section4 { get; set; }
        public string QuoteDocPath { get; set; }
        public string SignaturePath { get; set; }
    }
}
