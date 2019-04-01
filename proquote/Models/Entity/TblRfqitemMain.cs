using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblRfqitemMain
    {
        public int QuoteItemId { get; set; }
        public int? SectionId { get; set; }
        public int? ParentId { get; set; }
        public int? OldQuoteItemId { get; set; }
        public int? OrderId { get; set; }
        public string PartNumber { get; set; }
        public bool? IsFromPriceBook { get; set; }
        public string CostRule { get; set; }
        public string PriceRule { get; set; }
        public string ItemDiscountRule { get; set; }
        public double? Cost { get; set; }
        public double? Price { get; set; }
        public double? ItemDiscount { get; set; }
        public double? Quantity { get; set; }
        public string Description { get; set; }
        public string Suppliername { get; set; }
        public string Units { get; set; }
        public string Lbcode { get; set; }
        public double? Lbquantity { get; set; }
        public double? Lbcost { get; set; }
        public double? Lbprice { get; set; }
        public double? Lbdiscount { get; set; }
        public double? OrderQuantity { get; set; }
        public bool? OrderNow { get; set; }
        public bool? Accepted { get; set; }
        public string OrderLineInstructions { get; set; }
        public DateTime? LineItemRequestedShipDate { get; set; }
        public int? OldQuoteItemParentId { get; set; }
        public string DocName { get; set; }
        public bool? PrintDoc { get; set; }
        public string Image { get; set; }
        public bool? Viewinweb { get; set; }
        public byte[] Ts { get; set; }
        public double? RequestedPrice { get; set; }
        public string Notes { get; set; }
        public string ShortDescription { get; set; }
        public string Features { get; set; }
        public double? ListPrice { get; set; }
        public string ItemSize { get; set; }
        public double? ItemWeight { get; set; }
        public string ProductType { get; set; }
        public string Category { get; set; }
        public bool? ShowinQuote { get; set; }
        public string NetworkId { get; set; }
        public string UnitId { get; set; }
        public double? Uscost { get; set; }
        public bool? IsBaseModel { get; set; }
    }
}
