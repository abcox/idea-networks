using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblOrderItemMain
    {
        public int OrderItemId { get; set; }
        public int? QuoteId { get; set; }
        public string QuoteNumber { get; set; }
        public string Ponumber { get; set; }
        public int? SectionId { get; set; }
        public string SectionNumber { get; set; }
        public string SectionName { get; set; }
        public int? QuoteItemId { get; set; }
        public int? ParentId { get; set; }
        public string ItemNumber { get; set; }
        public string PartNumber { get; set; }
        public double? Quantity { get; set; }
        public string Description { get; set; }
        public string CostRule { get; set; }
        public string PriceRule { get; set; }
        public string ItemDiscountRule { get; set; }
        public double? Cost { get; set; }
        public double? Price { get; set; }
        public double? ItemDiscount { get; set; }
        public double? OrderQuantity { get; set; }
        public string OrderLineInstructions { get; set; }
        public bool OrderNow { get; set; }
        public DateTime? Transferdate { get; set; }
        public bool Accepted { get; set; }
        public DateTime? LineItemRequestedShipDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
