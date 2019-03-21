using System;
using System.Xml.Serialization;

namespace test.Models.TigerPaw
{
    [XmlRoot(ElementName = "BillTo")]
    public class BillTo
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Address1")]
        public string Address1 { get; set; }
        [XmlElement(ElementName = "Address2")]
        public string Address2 { get; set; }
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
        [XmlElement(ElementName = "State")]
        public string State { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactName")]
        public string ContactName { get; set; }
        [XmlElement(ElementName = "ContactPhone")]
        public string ContactPhone { get; set; }
    }

    [XmlRoot(ElementName = "ShipTo")]
    public class ShipTo
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Address1")]
        public string Address1 { get; set; }
        [XmlElement(ElementName = "Address2")]
        public string Address2 { get; set; }
        [XmlElement(ElementName = "City")]
        public string City { get; set; }
        [XmlElement(ElementName = "State")]
        public string State { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactName")]
        public string ContactName { get; set; }
        [XmlElement(ElementName = "ContactPhone")]
        public string ContactPhone { get; set; }
    }

    [XmlRoot(ElementName = "ServiceOrder")]
    public class ServiceOrder
    {
        [XmlElement(ElementName = "AccountNumber")]
        public int AccountNumber { get; set; }
        [XmlElement(ElementName = "AlternatePhoneNumber")]
        public string AlternatePhoneNumber { get; set; }
        [XmlElement(ElementName = "AlternatePhoneLocation")]
        public string AlternatePhoneLocation { get; set; }
        [XmlElement(ElementName = "ContactNumber")]
        public int ContactNumber { get; set; }
        [XmlElement(ElementName = "AlternateContactEmailAddress")]
        public string AlternateContactEmailAddress { get; set; }
        [XmlElement(ElementName = "AlternateContactPhoneNumber")]
        public string AlternateContactPhoneNumber { get; set; }
        [XmlElement(ElementName = "AlternateContactPhoneLocation")]
        public string AlternateContactPhoneLocation { get; set; }
        [XmlElement(ElementName = "InvoiceNumber")]
        public int InvoiceNumber { get; set; }
        [XmlElement(ElementName = "InvoicedStatus")]
        public string InvoicedStatus { get; set; }
        [XmlElement(ElementName = "InvoiceDate")]
        public DateTime InvoiceDate { get; set; }
        [XmlElement(ElementName = "TechnicianAssigned")]
        public int TechnicianAssigned { get; set; }
        [XmlElement(ElementName = "ContractNumber")]
        public int ContractNumber { get; set; }
        [XmlElement(ElementName = "CustomerPurchaseOrder")]
        public string CustomerPurchaseOrder { get; set; }
        [XmlElement(ElementName = "PurchaseOrderNumber")]
        public int PurchaseOrderNumber { get; set; }
        [XmlElement(ElementName = "ExternalAccountId")]
        public string ExternalAccountId { get; set; }
        [XmlElement(ElementName = "ManagedServiceProviderAlertId")]
        public string ManagedServiceProviderAlertId { get; set; }
        [XmlElement(ElementName = "Age")]
        public int Age { get; set; }
        [XmlElement(ElementName = "PrintedFlag")]
        public bool PrintedFlag { get; set; }
        [XmlElement(ElementName = "ServiceLevelAgreementDeadLine")]
        public DateTime ServiceLevelAgreementDeadLine { get; set; }
        [XmlElement(ElementName = "ServiceLevelAgreementWarning")]
        public DateTime ServiceLevelAgreementWarning { get; set; }
        [XmlElement(ElementName = "Priority")]
        public string Priority { get; set; }
        [XmlElement(ElementName = "ServiceOrderType")]
        public string ServiceOrderType { get; set; }
        [XmlElement(ElementName = "DateTimeReceived")]
        public DateTime DateTimeReceived { get; set; }
        [XmlElement(ElementName = "TakenBy")]
        public int TakenBy { get; set; }
        [XmlElement(ElementName = "DateTimeRequested")]
        public DateTime DateTimeRequested { get; set; }
        [XmlElement(ElementName = "DateRequested")]
        public DateTime DateRequested { get; set; }
        [XmlElement(ElementName = "TimeRequested")]
        public DateTime TimeRequested { get; set; }
        [XmlElement(ElementName = "RequestedBy")]
        public string RequestedBy { get; set; }
        [XmlElement(ElementName = "DateTimeOpened")]
        public DateTime DateTimeOpened { get; set; }
        [XmlElement(ElementName = "DateTimeClosed")]
        public DateTime DateTimeClosed { get; set; }
        [XmlElement(ElementName = "VerifiedDate")]
        public DateTime VerifiedDate { get; set; }
        [XmlElement(ElementName = "VerifiedBy")]
        public string VerifiedBy { get; set; }
        [XmlElement(ElementName = "ServiceZone")]
        public string ServiceZone { get; set; }
        [XmlElement(ElementName = "System")]
        public string System { get; set; }
        [XmlElement(ElementName = "Reference")]
        public string Reference { get; set; }
        [XmlElement(ElementName = "Status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "BillParent")]
        public string BillParent { get; set; }
        [XmlElement(ElementName = "BillTo")]
        public BillTo BillTo { get; set; }
        [XmlElement(ElementName = "ShipTo")]
        public ShipTo ShipTo { get; set; }
        [XmlElement(ElementName = "ResolvedOnPhone")]
        public bool ResolvedOnPhone { get; set; }
        [XmlElement(ElementName = "CallBackCount")]
        public int CallBackCount { get; set; }
        [XmlElement(ElementName = "BriefDescription")]
        public string BriefDescription { get; set; }
        [XmlElement(ElementName = "WorkRequested")]
        public string WorkRequested { get; set; }
        [XmlElement(ElementName = "WorkPerformed")]
        public string WorkPerformed { get; set; }
        [XmlElement(ElementName = "InternalComments")]
        public string InternalComments { get; set; }
        [XmlElement(ElementName = "ProductType")]
        public int ProductType { get; set; }
        [XmlElement(ElementName = "ProjectNumber")]
        public int ProjectNumber { get; set; }
        [XmlElement(ElementName = "ProjectPhaseNumber")]
        public int ProjectPhaseNumber { get; set; }
        [XmlElement(ElementName = "ProjectSubPhaseNumber")]
        public int ProjectSubPhaseNumber { get; set; }
        [XmlElement(ElementName = "DirectionsToLocation")]
        public string DirectionsToLocation { get; set; }
        [XmlElement(ElementName = "StatusChangeIndicator")]
        public bool StatusChangeIndicator { get; set; }
        [XmlElement(ElementName = "StatusChangeDate")]
        public DateTime StatusChangeDate { get; set; }
        [XmlElement(ElementName = "CanDiscountedItemsGetHeaderDiscount")]
        public bool CanDiscountedItemsGetHeaderDiscount { get; set; }
        [XmlElement(ElementName = "EstimatedHours")]
        public int EstimatedHours { get; set; }
        [XmlElement(ElementName = "EstimatedMinutes")]
        public int EstimatedMinutes { get; set; }
        [XmlElement(ElementName = "TagNumber")]
        public string TagNumber { get; set; }
        [XmlElement(ElementName = "LoanAgreement")]
        public string LoanAgreement { get; set; }
        [XmlElement(ElementName = "DebitCreditMemo")]
        public string DebitCreditMemo { get; set; }
        [XmlElement(ElementName = "DispatchBoardNumber")]
        public int DispatchBoardNumber { get; set; }
        [XmlElement(ElementName = "Severity")]
        public int Severity { get; set; }
        [XmlElement(ElementName = "PayMethodId")]
        public int PayMethodId { get; set; }
        [XmlElement(ElementName = "PaymentMethod")]
        public string PaymentMethod { get; set; }
        [XmlElement(ElementName = "InvoiceTerms")]
        public string InvoiceTerms { get; set; }
        [XmlElement(ElementName = "ARCustomerNumber")]
        public string ARCustomerNumber { get; set; }
        [XmlElement(ElementName = "ReadyToInvoice")]
        public bool ReadyToInvoice { get; set; }
        [XmlElement(ElementName = "RepToCredit")]
        public int RepToCredit { get; set; }
        [XmlElement(ElementName = "ShippingMethod")]
        public string ShippingMethod { get; set; }
        [XmlElement(ElementName = "GSTaxable")]
        public bool GSTaxable { get; set; }
        [XmlElement(ElementName = "GSTIsTaxable")]
        public bool GSTIsTaxable { get; set; }
        [XmlElement(ElementName = "GSTaxComputeBeforeTradeIn")]
        public bool GSTaxComputeBeforeTradeIn { get; set; }
        [XmlElement(ElementName = "GSTaxRate")]
        public int GSTaxRate { get; set; }
        [XmlElement(ElementName = "TaxComputedBeforeTradeIn")]
        public bool TaxComputedBeforeTradeIn { get; set; }
        [XmlElement(ElementName = "FreightTaxable")]
        public bool FreightTaxable { get; set; }
        [XmlElement(ElementName = "FreightTerms")]
        public string FreightTerms { get; set; }
        [XmlElement(ElementName = "Taxable")]
        public bool Taxable { get; set; }
        [XmlElement(ElementName = "DiscountPercent")]
        public int DiscountPercent { get; set; }
        [XmlElement(ElementName = "DiscountAmount")]
        public decimal DiscountAmount { get; set; }
        [XmlElement(ElementName = "DiscountSellForPrice")]
        public decimal DiscountSellForPrice { get; set; }
        [XmlElement(ElementName = "DiscountMarginPercent")]
        public int DiscountMarginPercent { get; set; }
        [XmlElement(ElementName = "SalesTaxCode")]
        public string SalesTaxCode { get; set; }
        [XmlElement(ElementName = "SalesTaxRate")]
        public int SalesTaxRate { get; set; }
        [XmlElement(ElementName = "TradeIn")]
        public decimal TradeIn { get; set; }
        [XmlElement(ElementName = "Deposit")]
        public decimal Deposit { get; set; }
        [XmlElement(ElementName = "TotalSellingPrice")]
        public decimal TotalSellingPrice { get; set; }
        [XmlElement(ElementName = "TotalDollarsDiscounted")]
        public decimal TotalDollarsDiscounted { get; set; }
        [XmlElement(ElementName = "TotalPercentDiscounted")]
        public int TotalPercentDiscounted { get; set; }
        [XmlElement(ElementName = "GSTax")]
        public decimal GSTax { get; set; }
        [XmlElement(ElementName = "GSTaxableAmount")]
        public decimal GSTaxableAmount { get; set; }
        [XmlElement(ElementName = "SalesTax")]
        public decimal SalesTax { get; set; }
        [XmlElement(ElementName = "TaxableAmount")]
        public decimal TaxableAmount { get; set; }
        [XmlElement(ElementName = "ProviderTax")]
        public decimal ProviderTax { get; set; }
        [XmlElement(ElementName = "ProviderTaxRate")]
        public decimal ProviderTaxRate { get; set; }
        [XmlElement(ElementName = "ProviderTaxableAmount")]
        public decimal ProviderTaxableAmount { get; set; }
        [XmlElement(ElementName = "Freight")]
        public decimal Freight { get; set; }
        [XmlElement(ElementName = "TotalDue")]
        public decimal TotalDue { get; set; }
        [XmlElement(ElementName = "BidPrice")]
        public decimal BidPrice { get; set; }
        [XmlElement(ElementName = "TotalCost")]
        public decimal TotalCost { get; set; }
        [XmlElement(ElementName = "VoidBy")]
        public int VoidBy { get; set; }
        [XmlElement(ElementName = "VoidDate")]
        public DateTime VoidDate { get; set; }
        [XmlElement(ElementName = "VoidReason")]
        public string VoidReason { get; set; }
        [XmlElement(ElementName = "SalesAgreementNumber")]
        public string SalesAgreementNumber { get; set; }
        [XmlElement(ElementName = "DispatchReference")]
        public string DispatchReference { get; set; }
        [XmlElement(ElementName = "IBMNumber")]
        public string IBMNumber { get; set; }
        [XmlElement(ElementName = "OtherReferenceNum")]
        public string OtherReferenceNum { get; set; }
        [XmlElement(ElementName = "ARReference")]
        public string ARReference { get; set; }
        [XmlElement(ElementName = "CustomerReference")]
        public string CustomerReference { get; set; }
        [XmlElement(ElementName = "GLReference")]
        public string GLReference { get; set; }
        [XmlElement(ElementName = "Miscellaneous")]
        public string Miscellaneous { get; set; }
        [XmlElement(ElementName = "Comment")]
        public string Comment { get; set; }
        [XmlElement(ElementName = "ExternalInvoice")]
        public string ExternalInvoice { get; set; }
        [XmlElement(ElementName = "WarrantyType")]
        public string WarrantyType { get; set; }
        [XmlElement(ElementName = "ManagedServiceProviderAlertUrl")]
        public string ManagedServiceProviderAlertUrl { get; set; }
        [XmlElement(ElementName = "DefaultBin")]
        public string DefaultBin { get; set; }
        [XmlElement(ElementName = "PostedStatus")]
        public string PostedStatus { get; set; }
        [XmlElement(ElementName = "ProgressiveInvoiceTotalComment")]
        public string ProgressiveInvoiceTotalComment { get; set; }
        [XmlElement(ElementName = "ServiceCategory")]
        public string ServiceCategory { get; set; }
        [XmlElement(ElementName = "StagingLocation")]
        public string StagingLocation { get; set; }
        [XmlElement(ElementName = "PriorityColor")]
        public int PriorityColor { get; set; }
        [XmlElement(ElementName = "SeverityRank")]
        public int SeverityRank { get; set; }
        [XmlElement(ElementName = "ActualHoursLogged")]
        public int ActualHoursLogged { get; set; }
        [XmlElement(ElementName = "ActualMinutesLogged")]
        public int ActualMinutesLogged { get; set; }
        [XmlElement(ElementName = "MeterReading")]
        public int MeterReading { get; set; }
        [XmlElement(ElementName = "OriginalServiceOrderNumber")]
        public int OriginalServiceOrderNumber { get; set; }
        [XmlElement(ElementName = "PriceLevel")]
        public int PriceLevel { get; set; }
        [XmlElement(ElementName = "PriorityRank")]
        public int PriorityRank { get; set; }
        [XmlElement(ElementName = "QuoteNumber")]
        public int QuoteNumber { get; set; }
        [XmlElement(ElementName = "ReceivedDateAge")]
        public int ReceivedDateAge { get; set; }
        [XmlElement(ElementName = "TotalHours")]
        public int TotalHours { get; set; }
        [XmlElement(ElementName = "TotalMinutes")]
        public int TotalMinutes { get; set; }
        [XmlElement(ElementName = "ARDate")]
        public DateTime ARDate { get; set; }
        [XmlElement(ElementName = "BMFLastProcessed")]
        public DateTime BMFLastProcessed { get; set; }
        [XmlElement(ElementName = "DateCreated")]
        public DateTime DateCreated { get; set; }
        [XmlElement(ElementName = "DateToInstall")]
        public DateTime DateToInstall { get; set; }
        [XmlElement(ElementName = "GLDate")]
        public DateTime GLDate { get; set; }
        [XmlElement(ElementName = "NextDate")]
        public DateTime NextDate { get; set; }
        [XmlElement(ElementName = "CreditsWereInvoiced")]
        public bool CreditsWereInvoiced { get; set; }
        [XmlElement(ElementName = "EmailConnectorUpdate")]
        public bool EmailConnectorUpdate { get; set; }
        [XmlElement(ElementName = "InThresholdEscalationNoticeSent")]
        public bool InThresholdEscalationNoticeSent { get; set; }
        [XmlElement(ElementName = "NeedToTestEscalation")]
        public bool NeedToTestEscalation { get; set; }
        [XmlElement(ElementName = "PastTargetEscalationNoticeSent")]
        public bool PastTargetEscalationNoticeSent { get; set; }
        [XmlElement(ElementName = "TaxLabor")]
        public bool TaxLabor { get; set; }
        [XmlElement(ElementName = "CreditBalance")]
        public decimal CreditBalance { get; set; }
        [XmlElement(ElementName = "TotalLaborCost")]
        public decimal TotalLaborCost { get; set; }
        [XmlElement(ElementName = "TotalLaborSellPrice")]
        public decimal TotalLaborSellPrice { get; set; }
        [XmlElement(ElementName = "TotalOtherCost")]
        public decimal TotalOtherCost { get; set; }
        [XmlElement(ElementName = "TotalOtherSellPrice")]
        public decimal TotalOtherSellPrice { get; set; }
        [XmlElement(ElementName = "UnappliedBOTradein")]
        public decimal UnappliedBOTradein { get; set; }
        [XmlElement(ElementName = "UnappliedGSTradein")]
        public decimal UnappliedGSTradein { get; set; }
        [XmlElement(ElementName = "UnappliedTradeIn")]
        public decimal UnappliedTradeIn { get; set; }
        [XmlElement(ElementName = "LaborHours")]
        public decimal LaborHours { get; set; }
        [XmlElement(ElementName = "SavingsPercent")]
        public decimal SavingsPercent { get; set; }
        [XmlElement(ElementName = "OrderSource")]
        public decimal OrderSource { get; set; }
        [XmlElement(ElementName = "DisplayOnCustomerPortal")]
        public bool DisplayOnCustomerPortal { get; set; }
    }

    [XmlRoot(ElementName = "ServiceOrderLock")]
    public class ServiceOrderLock
    {
        [XmlElement(ElementName = "LockingRepNumber")]
        public int LockingRepNumber { get; set; }
        [XmlElement(ElementName = "LockingRepName")]
        public string LockingRepName { get; set; }
    }

    [XmlRoot(ElementName = "ServiceOrderSummary")]
    public class ServiceOrderSummary
    {
        [XmlElement(ElementName = "ServiceOrderNumber")]
        public int ServiceOrderNumber { get; set; }
        [XmlElement(ElementName = "ServiceOrder")]
        public ServiceOrder ServiceOrder { get; set; }
        [XmlElement(ElementName = "AccountName")]
        public string AccountName { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "FaxNumber")]
        public string FaxNumber { get; set; }
        [XmlElement(ElementName = "ContactName")]
        public string ContactName { get; set; }
        [XmlElement(ElementName = "ContactEmailAddress")]
        public string ContactEmailAddress { get; set; }
        [XmlElement(ElementName = "ContactPhoneNumber")]
        public string ContactPhoneNumber { get; set; }
        [XmlElement(ElementName = "PrimaryTechnicianName")]
        public string PrimaryTechnicianName { get; set; }
        [XmlElement(ElementName = "PrimaryTechnicianEmailAddress")]
        public string PrimaryTechnicianEmailAddress { get; set; }
        [XmlElement(ElementName = "PrimaryTechnicianPhoneNumber")]
        public string PrimaryTechnicianPhoneNumber { get; set; }
        [XmlElement(ElementName = "TakenByName")]
        public string TakenByName { get; set; }
        [XmlElement(ElementName = "PriceLevelDescription")]
        public string PriceLevelDescription { get; set; }
        [XmlElement(ElementName = "PayMethodName")]
        public string PayMethodName { get; set; }
        [XmlElement(ElementName = "ProjectDescription")]
        public string ProjectDescription { get; set; }
        [XmlElement(ElementName = "ProjectPhase")]
        public string ProjectPhase { get; set; }
        [XmlElement(ElementName = "RepToCreditName")]
        public string RepToCreditName { get; set; }
        [XmlElement(ElementName = "VoidedByName")]
        public string VoidedByName { get; set; }
        [XmlElement(ElementName = "ContractDescription")]
        public string ContractDescription { get; set; }
        [XmlElement(ElementName = "ContractExpiration")]
        public DateTime ContractExpiration { get; set; }
        [XmlElement(ElementName = "ExternalProductName")]
        public string ExternalProductName { get; set; }
        [XmlElement(ElementName = "SeverityDescription")]
        public string SeverityDescription { get; set; }
        [XmlElement(ElementName = "TotalExpenses")]
        public decimal TotalExpenses { get; set; }
        [XmlElement(ElementName = "ServiceOrderProfiles")]
        public int ServiceOrderProfiles { get; set; }
        [XmlElement(ElementName = "ServiceOrderSymptoms")]
        public int ServiceOrderSymptoms { get; set; }
        [XmlElement(ElementName = "ServiceOrderResolution")]
        public int ServiceOrderResolution { get; set; }
        [XmlElement(ElementName = "PartsUsed")]
        public int PartsUsed { get; set; }
        [XmlElement(ElementName = "ItemsServiced")]
        public int ItemsServiced { get; set; }
        [XmlElement(ElementName = "TimeLogs")]
        public int TimeLogs { get; set; }
        [XmlElement(ElementName = "OpenTasks")]
        public int OpenTasks { get; set; }
        [XmlElement(ElementName = "Notes")]
        public int Notes { get; set; }
        [XmlElement(ElementName = "SubContractors")]
        public int SubContractors { get; set; }
        [XmlElement(ElementName = "Quotes")]
        public int Quotes { get; set; }
        [XmlElement(ElementName = "ChangeOrders")]
        public int ChangeOrders { get; set; }
        [XmlElement(ElementName = "HasParentServiceOrders")]
        public bool HasParentServiceOrders { get; set; }
        [XmlElement(ElementName = "HasChildServiceOrders")]
        public bool HasChildServiceOrders { get; set; }
        [XmlElement(ElementName = "HasBeenSigned")]
        public bool HasBeenSigned { get; set; }
        [XmlElement(ElementName = "HasRecurringOrder")]
        public bool HasRecurringOrder { get; set; }
        [XmlElement(ElementName = "ServiceOrderLock")]
        public ServiceOrderLock ServiceOrderLock { get; set; }
        [XmlElement(ElementName = "HasProjectBeenInvoiced")]
        public bool HasProjectBeenInvoiced { get; set; }
    }

    [XmlRoot(ElementName = "ServiceOrderResponse")]
    public class ServiceOrdersPostResponse
    {
        [XmlElement(ElementName = "ServiceOrderSummary")]
        public ServiceOrderSummary ServiceOrderSummary { get; set; }
        [XmlElement(ElementName = "Success")]
        public bool Success { get; set; }
        [XmlElement(ElementName = "Message")]
        public string Message { get; set; }
    }

}