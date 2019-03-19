using System;
using System.Collections.Generic;
using System.Text;

namespace test.Models.TigerPaw
{
    class ServiceOrdersPostResponse
    {
        public ServiceOrderSummary ServiceOrderSummary { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    //public class BillTo
    //{
    //    public string Name { get; set; }
    //    public string Address1 { get; set; }
    //    public string Address2 { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string PostalCode { get; set; }
    //    public string Country { get; set; }
    //    public string ContactName { get; set; }
    //    public string ContactPhone { get; set; }
    //}

    //public class ShipTo
    //{
    //    public string Name { get; set; }
    //    public string Address1 { get; set; }
    //    public string Address2 { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string PostalCode { get; set; }
    //    public string Country { get; set; }
    //    public string ContactName { get; set; }
    //    public string ContactPhone { get; set; }
    //}

    public class ServiceOrder
    {
        public int AccountNumber { get; set; }
        public string AlternatePhoneNumber { get; set; }
        public string AlternatePhoneLocation { get; set; }
        public int ContactNumber { get; set; }
        public string AlternateContactEmailAddress { get; set; }
        public string AlternateContactPhoneNumber { get; set; }
        public string AlternateContactPhoneLocation { get; set; }
        public int InvoiceNumber { get; set; }
        public string InvoicedStatus { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int TechnicianAssigned { get; set; }
        public int ContractNumber { get; set; }
        public string CustomerPurchaseOrder { get; set; }
        public int PurchaseOrderNumber { get; set; }
        public string ExternalAccountId { get; set; }
        public string ManagedServiceProviderAlertId { get; set; }
        public int Age { get; set; }
        public bool PrintedFlag { get; set; }
        public DateTime ServiceLevelAgreementDeadLine { get; set; }
        public DateTime ServiceLevelAgreementWarning { get; set; }
        public string Priority { get; set; }
        public string ServiceOrderType { get; set; }
        public DateTime DateTimeReceived { get; set; }
        public int TakenBy { get; set; }
        public DateTime DateTimeRequested { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime TimeRequested { get; set; }
        public string RequestedBy { get; set; }
        public DateTime DateTimeOpened { get; set; }
        public DateTime DateTimeClosed { get; set; }
        public DateTime VerifiedDate { get; set; }
        public string VerifiedBy { get; set; }
        public string ServiceZone { get; set; }
        public string System { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
        public bool BillParent { get; set; }
        public BillTo BillTo { get; set; }
        public ShipTo ShipTo { get; set; }
        public bool ResolvedOnPhone { get; set; }
        public int CallBackCount { get; set; }
        public string BriefDescription { get; set; }
        public string WorkRequested { get; set; }
        public string WorkPerformed { get; set; }
        public string InternalComments { get; set; }
        public int ProductType { get; set; }
        public int ProjectNumber { get; set; }
        public int ProjectPhaseNumber { get; set; }
        public int ProjectSubPhaseNumber { get; set; }
        public string DirectionsToLocation { get; set; }
        public bool StatusChangeIndicator { get; set; }
        public DateTime StatusChangeDate { get; set; }
        public bool CanDiscountedItemsGetHeaderDiscount { get; set; }
        public int EstimatedHours { get; set; }
        public int EstimatedMinutes { get; set; }
        public string TagNumber { get; set; }
        public string LoanAgreement { get; set; }
        public string DebitCreditMemo { get; set; }
        public int DispatchBoardNumber { get; set; }
        public int Severity { get; set; }
        public int PayMethodId { get; set; }
        public string PaymentMethod { get; set; }
        public string InvoiceTerms { get; set; }
        public string ARCustomerNumber { get; set; }
        public bool ReadyToInvoice { get; set; }
        public int RepToCredit { get; set; }
        public string ShippingMethod { get; set; }
        public bool GSTaxable { get; set; }
        public bool GSTIsTaxable { get; set; }
        public bool GSTaxComputeBeforeTradeIn { get; set; }
        public int GSTaxRate { get; set; }
        public bool TaxComputedBeforeTradeIn { get; set; }
        public bool FreightTaxable { get; set; }
        public string FreightTerms { get; set; }
        public bool Taxable { get; set; }
        public int DiscountPercent { get; set; }
        public int DiscountAmount { get; set; }
        public int DiscountSellForPrice { get; set; }
        public int DiscountMarginPercent { get; set; }
        public string SalesTaxCode { get; set; }
        public int SalesTaxRate { get; set; }
        public int TradeIn { get; set; }
        public int Deposit { get; set; }
        public int TotalSellingPrice { get; set; }
        public int TotalDollarsDiscounted { get; set; }
        public int TotalPercentDiscounted { get; set; }
        public int GSTax { get; set; }
        public int GSTaxableAmount { get; set; }
        public int SalesTax { get; set; }
        public int TaxableAmount { get; set; }
        public int ProviderTax { get; set; }
        public int ProviderTaxRate { get; set; }
        public int ProviderTaxableAmount { get; set; }
        public int Freight { get; set; }
        public int TotalDue { get; set; }
        public int BidPrice { get; set; }
        public int TotalCost { get; set; }
        public int VoidBy { get; set; }
        public DateTime VoidDate { get; set; }
        public string VoidReason { get; set; }
        public string SalesAgreementNumber { get; set; }
        public string DispatchReference { get; set; }
        public string IBMNumber { get; set; }
        public string OtherReferenceNum { get; set; }
        public string ARReference { get; set; }
        public string CustomerReference { get; set; }
        public string GLReference { get; set; }
        public string Miscellaneous { get; set; }
        public string Comment { get; set; }
        public string ExternalInvoice { get; set; }
        public string WarrantyType { get; set; }
        public string ManagedServiceProviderAlertUrl { get; set; }
        public string DefaultBin { get; set; }
        public string PostedStatus { get; set; }
        public string ProgressiveInvoiceTotalComment { get; set; }
        public string ServiceCategory { get; set; }
        public string StagingLocation { get; set; }
        public int PriorityColor { get; set; }
        public int SeverityRank { get; set; }
        public int ActualHoursLogged { get; set; }
        public int ActualMinutesLogged { get; set; }
        public int MeterReading { get; set; }
        public int OriginalServiceOrderNumber { get; set; }
        public int PriceLevel { get; set; }
        public int PriorityRank { get; set; }
        public int QuoteNumber { get; set; }
        public int ReceivedDateAge { get; set; }
        public int TotalHours { get; set; }
        public int TotalMinutes { get; set; }
        public DateTime ARDate { get; set; }
        public DateTime BMFLastProcessed { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateToInstall { get; set; }
        public DateTime GLDate { get; set; }
        public DateTime NextDate { get; set; }
        public bool CreditsWereInvoiced { get; set; }
        public bool EmailConnectorUpdate { get; set; }
        public bool InThresholdEscalationNoticeSent { get; set; }
        public bool NeedToTestEscalation { get; set; }
        public bool PastTargetEscalationNoticeSent { get; set; }
        public bool TaxLabor { get; set; }
        public int CreditBalance { get; set; }
        public int TotalLaborCost { get; set; }
        public int TotalLaborSellPrice { get; set; }
        public int TotalOtherCost { get; set; }
        public int TotalOtherSellPrice { get; set; }
        public int UnappliedBOTradein { get; set; }
        public int UnappliedGSTradein { get; set; }
        public int UnappliedTradeIn { get; set; }
        public int LaborHours { get; set; }
        public int SavingsPercent { get; set; }
        public int OrderSource { get; set; }
        public bool DisplayOnCustomerPortal { get; set; }
    }

    public class ServiceOrderLock
    {
        public int LockingRepNumber { get; set; }
        public string LockingRepName { get; set; }
    }

    public class ServiceOrderSummary
    {
        public int ServiceOrderNumber { get; set; }
        public ServiceOrder ServiceOrder { get; set; }
        public string AccountName { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string ContactName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string PrimaryTechnicianName { get; set; }
        public string PrimaryTechnicianEmailAddress { get; set; }
        public string PrimaryTechnicianPhoneNumber { get; set; }
        public string TakenByName { get; set; }
        public string PriceLevelDescription { get; set; }
        public string PayMethodName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectPhase { get; set; }
        public string RepToCreditName { get; set; }
        public string VoidedByName { get; set; }
        public string ContractDescription { get; set; }
        public DateTime ContractExpiration { get; set; }
        public string ExternalProductName { get; set; }
        public string SeverityDescription { get; set; }
        public int TotalExpenses { get; set; }
        public int ServiceOrderProfiles { get; set; }
        public int ServiceOrderSymptoms { get; set; }
        public int ServiceOrderResolution { get; set; }
        public int PartsUsed { get; set; }
        public int ItemsServiced { get; set; }
        public int TimeLogs { get; set; }
        public int OpenTasks { get; set; }
        public int Notes { get; set; }
        public int SubContractors { get; set; }
        public int Quotes { get; set; }
        public int ChangeOrders { get; set; }
        public bool HasParentServiceOrders { get; set; }
        public bool HasChildServiceOrders { get; set; }
        public bool HasBeenSigned { get; set; }
        public bool HasRecurringOrder { get; set; }
        public ServiceOrderLock ServiceOrderLock { get; set; }
        public bool HasProjectBeenInvoiced { get; set; }
    }
}
