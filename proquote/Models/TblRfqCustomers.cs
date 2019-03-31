using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblRfqCustomers
    {
        public int QuoteCustomerId { get; set; }
        public int? QuoteId { get; set; }
        public bool? IsActive { get; set; }
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
        public byte[] Ts { get; set; }
        public string CustomerGroup { get; set; }
        public string SalesGroup { get; set; }
        public bool? BillTo { get; set; }
        public bool? ShipTo { get; set; }
        public string AcctCode { get; set; }
        public string Region { get; set; }
        public string PaymentTerms { get; set; }
        public string ContactCellPhone { get; set; }
        public string RepCode { get; set; }
        public string ShipTerms { get; set; }
        public string SecondaryPhone { get; set; }
        public string SecondaryContact { get; set; }
        public string SecondaryFax { get; set; }
        public string SecondaryCell { get; set; }
        public string SecondaryEmail { get; set; }
    }
}
