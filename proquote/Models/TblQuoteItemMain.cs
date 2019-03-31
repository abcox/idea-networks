using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteItemMain
    {
        public int QuoteItemId { get; set; }
        public int? SectionId { get; set; }
        public int? ParentId { get; set; }
        public int? OrderId { get; set; }
        public int? OldQuoteItemId { get; set; }
        public int? OldQuoteItemParentId { get; set; }
        public string PartNumber { get; set; }
        public string AltPartNumber { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string CostRule { get; set; }
        public string PriceRule { get; set; }
        public string GroupName { get; set; }
        public string ItemDiscountRule { get; set; }
        public double? Cost { get; set; }
        public double? Price { get; set; }
        public double? ItemDiscount { get; set; }
        public string Lbcode { get; set; }
        public double? Lbquantity { get; set; }
        public double? Lbcost { get; set; }
        public double? Lbprice { get; set; }
        public double? Lbdiscount { get; set; }
        public string Units { get; set; }
        public string Suppliername { get; set; }
        public string DocName { get; set; }
        public string Image { get; set; }
        public double? OrderQuantity { get; set; }
        public bool? OrderNow { get; set; }
        public bool? Accepted { get; set; }
        public string OrderLineInstructions { get; set; }
        public DateTime? LineItemRequestedShipDate { get; set; }
        public bool? PrintDoc { get; set; }
        public bool? ShowInQuote { get; set; }
        public double? Quantity { get; set; }
        public bool? IsFromPriceBook { get; set; }
        public bool? Viewinweb { get; set; }
        public byte[] Ts { get; set; }
        public bool? IsBaseModel { get; set; }
        public bool? IsKit { get; set; }
        public string Features { get; set; }
        public double? TotalItemCost { get; set; }
        public double? TotalItemPrice { get; set; }
        public double? NetItemPrice { get; set; }
        public double? GrossItemMargin { get; set; }
        public double? MaterialCost { get; set; }
        public double? StartingMargin { get; set; }
        public string SupplierCurrency { get; set; }
        public string LandedCost { get; set; }
        public string SellPrice { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public bool? Expense { get; set; }
        public short? Warehouse { get; set; }
        public bool? ShowInBom { get; set; }
        public string XlabourHrs { get; set; }
    }
}
