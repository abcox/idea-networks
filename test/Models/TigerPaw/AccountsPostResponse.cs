using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace test.Models.TigerPaw
{
    [XmlRoot(
        //Namespace = "www.contoso.com",
        ElementName = "AccountResponse",
        DataType = "string",
        IsNullable = true
        )]
    public class AccountsPostResponse
    {
        public AccountSummary AccountSummary { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    //public class Account
    //{
    //    public string Name { get; set; }
    //    public string AccountId { get; set; }
    //    public string Address1 { get; set; }
    //    public string Address2 { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string PostalCode { get; set; }
    //    public string Country { get; set; }
    //    public string AccountType { get; set; }
    //    public string Status { get; set; }
    //    public string HotNote { get; set; }
    //    public string DirectionsToLocation { get; set; }
    //    public string SpecialInstructions { get; set; }
    //    public string QuoteSpecialInstructions { get; set; }
    //    public string StatusLabelAction { get; set; }
    //    public string URL1 { get; set; }
    //    public string URL1Description { get; set; }
    //    public string URL2 { get; set; }
    //    public string URL2Description { get; set; }
    //    public DateTime InitialContact { get; set; }
    //    public int StatusLabelActionId { get; set; }
    //    public int RepNumber { get; set; }
    //    public int PrimaryContactNumber { get; set; }
    //    public bool IsVendor { get; set; }
    //    public bool IsSubcontractor { get; set; }
    //    public bool DoNotEmail { get; set; }
    //    public bool IsOwnedByPublicRep { get; set; }
    //    public bool CanReassignRepsAccount { get; set; }
    //}

    public class AccountSummary
    {
        public int AccountNumber { get; set; }
        public Account Account { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string RepName { get; set; }
        public string RepEmailAddress { get; set; }
        public string RepPhoneNumber { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactEmailAddress { get; set; }
        public string PrimaryContactPhoneNumber { get; set; }
        public int RelatedAccounts { get; set; }
        public int ParentAccountNumber { get; set; }
        public int JournalEntries { get; set; }
        public int OpenInvoices { get; set; }
        public int OpenQuotes { get; set; }
        public int OpenOpportunities { get; set; }
        public int OpenProjectCount { get; set; }
        public int OpenServiceOrders { get; set; }
        public int PastDueTasks { get; set; }
        public int OpenRMAs { get; set; }
        public int NumberOfContacts { get; set; }
    }
}