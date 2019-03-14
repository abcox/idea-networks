using System;
using System.Collections.Generic;
using System.Text;

namespace test.Models.TigerPaw
{
    class ServiceOrderPartsUsedResponse
    {
        public List<PartsUsed> PartsUsed { get; set; }
        public int PageSize { get; set; }
        public int NextRow { get; set; }
        public int TotalCount { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class Assembly
    {
        public int PartUsedAssemblyDetailNumber { get; set; }
        public int InvoiceAssemblyDetailNumber { get; set; }
        public int EachQuantity { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public string Memo { get; set; }
        public string CostGLCode { get; set; }
        public string IncomeGLCode { get; set; }
        public string RMANumber { get; set; }
        public string Type { get; set; }
        public bool ExchangeFlag { get; set; }
        public bool GSTExempt { get; set; }
        public bool PrintOnInvoice { get; set; }
        public bool SubjectToProviderTax { get; set; }
        public bool Taxable { get; set; }
        public bool UnderContract { get; set; }
        public bool UseThisCostWhenOrdering { get; set; }
        public bool WasTaxed { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime OrderByDate { get; set; }
        public int Quantity { get; set; }
        public int QuantityFilled { get; set; }
        public int QuantityInvoiced { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityPosted { get; set; }
        public int QuantityReceived { get; set; }
        public int ContractNumber { get; set; }
        public int ExchangeNumber { get; set; }
        public int ItemServicedNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public int LineNumber { get; set; }
        public int PriceLevel { get; set; }
        public int ActualUnitCost { get; set; }
        public int Cost { get; set; }
        public int GSTaxableAmount { get; set; }
        public int ManufacturerListPrice { get; set; }
        public int ProviderTaxableAmount { get; set; }
        public int SellingPrice { get; set; }
        public int TaxableAmount { get; set; }
        public int TotalCost { get; set; }
        public int TotalPostedCost { get; set; }
        public int TotalSellingPrice { get; set; }
    }

    public class PartsUsed
    {
        public int PartsUsedNumber { get; set; }
        public int ContractDetailNumber { get; set; }
        public int InvoiceDetailNumber { get; set; }
        public int VendorAccountNumber { get; set; }
        public int ProjectPhaseNumber { get; set; }
        public string RepairCode { get; set; }
        public string InstallLocation { get; set; }
        public string NonStockVendorItemNumber { get; set; }
        public bool AllowVolumePricing { get; set; }
        public bool AssemblyFlag { get; set; }
        public bool IsCommentOnly { get; set; }
        public bool ItemCanBeDiscounted { get; set; }
        public bool SingleItemTaxed { get; set; }
        public bool IsStockItem { get; set; }
        public int QuantityAvailableToInvoice { get; set; }
        public int QuantityShipped { get; set; }
        public int QuantityToInvoice { get; set; }
        public int QuantityToShip { get; set; }
        public int DiscountAmount { get; set; }
        public int AdjustmentAmount { get; set; }
        public int AdjustmentPercent { get; set; }
        public int DiscountPercent { get; set; }
        public bool IsSerialized { get; set; }
        public List<Assembly> Assembly { get; set; }
        public string ApplyDiscountOff { get; set; }
        public string PriceAdjuster { get; set; }
        public string ItemID { get; set; }
        public string ItemDescription { get; set; }
        public string Memo { get; set; }
        public string CostGLCode { get; set; }
        public string IncomeGLCode { get; set; }
        public string RMANumber { get; set; }
        public string Type { get; set; }
        public bool ExchangeFlag { get; set; }
        public bool GSTExempt { get; set; }
        public bool PrintOnInvoice { get; set; }
        public bool SubjectToProviderTax { get; set; }
        public bool Taxable { get; set; }
        public bool UnderContract { get; set; }
        public bool UseThisCostWhenOrdering { get; set; }
        public bool WasTaxed { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime OrderByDate { get; set; }
        public int Quantity { get; set; }
        public int QuantityFilled { get; set; }
        public int QuantityInvoiced { get; set; }
        public int QuantityOrdered { get; set; }
        public int QuantityPosted { get; set; }
        public int QuantityReceived { get; set; }
        public int ContractNumber { get; set; }
        public int ExchangeNumber { get; set; }
        public int ItemServicedNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public int LineNumber { get; set; }
        public int PriceLevel { get; set; }
        public int ActualUnitCost { get; set; }
        public int Cost { get; set; }
        public int GSTaxableAmount { get; set; }
        public int ManufacturerListPrice { get; set; }
        public int ProviderTaxableAmount { get; set; }
        public int SellingPrice { get; set; }
        public int TaxableAmount { get; set; }
        public int TotalCost { get; set; }
        public int TotalPostedCost { get; set; }
        public int TotalSellingPrice { get; set; }
    }
}
