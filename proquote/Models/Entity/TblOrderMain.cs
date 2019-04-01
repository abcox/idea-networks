using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblOrderMain
    {
        public int OrderQuoteId { get; set; }
        public double? QuoteId { get; set; }
        public string QuoteNumber { get; set; }
        public string Ponumber { get; set; }
        public string Description { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string ContactName { get; set; }
        public DateTime? DateIssued { get; set; }
        public string LastStatus { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public DateTime? OrderTransferdate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string BillToCode { get; set; }
        public string ShipToCode { get; set; }
        public string OrderInstructions { get; set; }
        public DateTime? RequestedShipDate { get; set; }
        public byte[] Ts { get; set; }
    }
}
