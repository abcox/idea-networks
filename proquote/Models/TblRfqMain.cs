using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblRfqMain
    {
        public int QuoteId { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string CopiedTo { get; set; }
        public string CopiedFrom { get; set; }
        public DateTime? LastExportDate { get; set; }
        public bool? IsTemplate { get; set; }
        public bool? Rounding { get; set; }
        public string Description { get; set; }
        public string InternalComments { get; set; }
        public string Salesman { get; set; }
        public string SecondarySalesman { get; set; }
        public string AuthorizedBy { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string LastStatus { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public DateTime? DateRequired { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? DateExpired { get; set; }
        public DateTime? ExpectedAwardDate { get; set; }
        public double? ProbabilityOfWinning { get; set; }
        public double? TotalQuoted { get; set; }
        public double? TotalCost { get; set; }
        public string FaxLetter { get; set; }
        public string CoverLetter { get; set; }
        public string QuoteHeader { get; set; }
        public string QuoteFooter { get; set; }
        public string TermsAndConditions { get; set; }
        public string FaxTitle { get; set; }
        public string CoverTitle { get; set; }
        public string HeaderTitle { get; set; }
        public string FooterTitle { get; set; }
        public string TermsTitle { get; set; }
        public bool? ShowFaxLetter { get; set; }
        public bool? ShowCoverLetter { get; set; }
        public bool? ShowQuoteHeader { get; set; }
        public bool? ShowQuoteFooter { get; set; }
        public bool? ShowTermsAndConditions { get; set; }
        public bool? ShowGrandTotal { get; set; }
        public bool? ShowDiscount { get; set; }
        public bool? ShowItemNumbers { get; set; }
        public bool? ShowCost { get; set; }
        public bool? ShowChildParts { get; set; }
        public bool? ShowReportHeader { get; set; }
        public bool? ShowReportPageHeader { get; set; }
        public bool? ShowreportFooter { get; set; }
        public bool? ShowReportPageFooter { get; set; }
        public string Ponumber { get; set; }
        public string ShipToCode { get; set; }
        public string OrderInstructions { get; set; }
        public DateTime? OrderTransferdate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string BillToCode { get; set; }
        public DateTime? RequestedShipdate { get; set; }
        public DateTime? LastImportdate { get; set; }
        public string ExportFileName { get; set; }
        public string ImportFileName { get; set; }
        public string SyncGroup { get; set; }
        public bool? DeleteFlag { get; set; }
        public bool? ViewInWeb { get; set; }
        public string Notes { get; set; }
        public bool? Alarm { get; set; }
        public string AlarmText { get; set; }
        public byte[] Ts { get; set; }
        public string EndUser { get; set; }
        public bool? MergePdf { get; set; }
        public string QuotePdfs { get; set; }
        public double? ExchangeRate { get; set; }
        public int? QuotingCurrency { get; set; }
        public string Region { get; set; }
        public string Competitors { get; set; }
        public string WinningBidder { get; set; }
        public double? WinningPrice { get; set; }
        public string SpecialConditions { get; set; }
        public string SalesStage { get; set; }
        public string SalesMethod { get; set; }
        public string SalesStatus { get; set; }
        public string QuoteleadQuality { get; set; }
        public string PaymentTerms { get; set; }
        public string Shipterms { get; set; }
        public string Shipvia { get; set; }
    }
}
