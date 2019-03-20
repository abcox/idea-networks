using System;
using System.Collections.Generic;
using System.Text;

namespace test.Models.TigerPaw
{
    public class AccountsPostRequest
    {
        public Account Account { get; set; }
        public PrimaryPhoneNumber PrimaryPhoneNumber { get; set; }
        public string AccountSource { get; set; }
    }

    public class Account
    {
        public string Name { get; set; }
        public string AccountId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AccountType { get; set; }
        public string Status { get; set; }
        public string HotNote { get; set; }
        public string DirectionsToLocation { get; set; }
        public string SpecialInstructions { get; set; }
        public string QuoteSpecialInstructions { get; set; }
        public string StatusLabelAction { get; set; }
        public string URL1 { get; set; }
        public string URL1Description { get; set; }
        public string URL2 { get; set; }
        public string URL2Description { get; set; }
        public DateTime InitialContact { get; set; }
        public int StatusLabelActionId { get; set; }
        public int RepNumber { get; set; }
        public int PrimaryContactNumber { get; set; }
        public bool IsVendor { get; set; }
        public bool IsSubcontractor { get; set; }
        public bool DoNotEmail { get; set; }
        public bool IsOwnedByPublicRep { get; set; }
        public bool CanReassignRepsAccount { get; set; }
    }

    public class PrimaryPhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }
        public bool IsPrimary { get; set; }
    }
}

