using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class ArchTblQuoteCustomers
    {
        public int ArchCustId { get; set; }
        public string QuoteName { get; set; }
        public int? QuoteCustomerId { get; set; }
        public int? QuoteId { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PhoneExtn { get; set; }
        public string Fax { get; set; }
        public string ContactName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string ContactNotes { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerType { get; set; }
        public double? CustomerDiscount { get; set; }
        public string AlternatePhone { get; set; }
        public string AltPhoneExtn { get; set; }
        public string CustomerGroup { get; set; }
        public string SalesGroup { get; set; }
        public bool ShipTo { get; set; }
        public bool BillTo { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CustomerNotes { get; set; }
        public string Mobile { get; set; }
    }
}
