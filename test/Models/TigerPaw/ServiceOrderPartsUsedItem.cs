using System;
using System.Collections.Generic;
using System.Text;

namespace test.Models.TigerPaw
{
    class ServiceOrderPartsUsedItem // aka. CreateServiceOrderPartsUsedModel
    {
        public int LineNumber { get; set; }
        public string ItemId { get; set; }
        public int PriceBookItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public bool UseBookPricesAndDiscounts { get; set; }
        public bool AllowPriceLessThanCost { get; set; }
        public bool Taxable { get; set; }
        public bool SubjectToProviderTax { get; set; }
        public bool PrintOnInvoice { get; set; }
        public bool UnderContract { get; set; }
        public bool ItemCanBeDiscounted { get; set; }
        public int EstimatedCost { get; set; }
        public bool UseThisCostWhenOrdering { get; set; }
        public string CostGLCode { get; set; }
        public string IncomeGLCode { get; set; }
        public int PriceLevel { get; set; }
        public int SellingPrice { get; set; }
        public int Quantity { get; set; }
        public int ServiceOrderItemsServicedNumber { get; set; }
        public string Memo { get; set; }
        public OrderByDate OrderByDate { get; set; }
        public int ProjectPhaseNumber { get; set; }
        public string InstallLocation { get; set; }
    }

    public class OrderByDate
    {
        public DateTime DateTime { get; set; }
    }
}
