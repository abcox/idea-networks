using System;
using System.Collections.Generic;
using System.Text;

namespace test.Models.TigerPaw
{
    public class ServiceOrdersPostRequest
    {
        public ServiceOrdersPostRequest()
        {
            AccountNumber = 0;
            ContactNumber = 0;
            TechnicianAssigned= 0;
            EstimatedHours= 0;
            EstimatedMinutes= 0;
            CallBackCount= 0;
            RepToCredit= 0;
            ContractNumber= 0;
            TakenBy= 0;
            DispatchBoardNumber= 0;
            PayMethodsId= 0;
            Severity= 0;
            AlternatePhoneNumber= string.Empty;
            AlternatePhoneLocation= string.Empty;
            AlternateContactEmailAddress= string.Empty;
            AlternateContactPhoneNumber= string.Empty;
            AlternateContactPhoneLocation= string.Empty;
            BriefDescription= string.Empty;
            Reference= string.Empty;
            Priority= string.Empty;
            Status= string.Empty;
            ServiceOrderType= string.Empty;
            System= string.Empty;
            WorkRequested= string.Empty;
            WorkPerformed= string.Empty;
            PaymentMethod= string.Empty;
            ShippingMethod= string.Empty;
            InternalComments= string.Empty;
            DirectionsToLocation= string.Empty;
            CustomerPurchaseOrder= string.Empty;
            VerifiedBy= string.Empty;
            ServiceZone= string.Empty;
            RequestedBy= string.Empty;
            TagNumber= string.Empty;
            LoanAgreement= string.Empty;
            DebitCreditMemo= string.Empty;
            InvoiceTerms= string.Empty;
            FreightTerms= string.Empty;
            SalesTaxCode= string.Empty;
            DateTimeReceived= new DateTime(); // 2019-03-19T00=57=14.823Z
            DateTimeRequested = new DateTimeRequested {
                Date = new DateTime(),
                Time= new DateTime()
            };
            DateTimeOpened= new DateTimeOpened {
                DateTime = new DateTime()
            };
            DateTimeClosed= new DateTimeClosed {
                DateTime = new DateTime()
            };
            VerifiedDate= new VerifiedDate {
                DateTime = new DateTime()
            };
            ResolvedOnPhone= true;
            BidPrice= 0;
            TradeIn= 0;
            Deposit= 0;
            Freight= 0;
            BillToAddressType= string.Empty;
            BillToAddressAccountNumber= 0;
            BillTo= new BillTo {
                Name = string.Empty,
                Address1= string.Empty,
                Address2= string.Empty,
                City= string.Empty,
                State= string.Empty,
                PostalCode= string.Empty,
                Country= string.Empty,
                ContactName= string.Empty,
                ContactPhone= string.Empty
            };
            ShipToAddressType= string.Empty;
            ShipToAddressAccountNumber= 0;
            ShipTo= new ShipTo {
                Name = string.Empty,
                Address1= string.Empty,
                Address2= string.Empty,
                City= string.Empty,
                State= string.Empty,
                PostalCode= string.Empty,
                Country= string.Empty,
                ContactName= string.Empty,
                ContactPhone= string.Empty
            };
            UseAlternateShipToTaxCode= true;
            CanReassignToHourlyUsageContractAlreadyInvoiced= true;
            CanUpdateContractMeterReadingToServiceOrderReading= true;
            AllowInactiveContract= true;
            AllowFutureContract= true;
            AllowContractNoRemaining= true;
            UseContractDefaultTech= true;
            DisplayOnCustomerPortal = true;
        }

        public int AccountNumber { get; set; }
        public int ContactNumber { get; set; }
        public int TechnicianAssigned { get; set; }
        public int EstimatedHours { get; set; }
        public int EstimatedMinutes { get; set; }
        public int CallBackCount { get; set; }
        public int RepToCredit { get; set; }
        public int ContractNumber { get; set; }
        public int TakenBy { get; set; }
        public int DispatchBoardNumber { get; set; }
        public int PayMethodsId { get; set; }
        public int Severity { get; set; }
        public string AlternatePhoneNumber { get; set; }
        public string AlternatePhoneLocation { get; set; }
        public string AlternateContactEmailAddress { get; set; }
        public string AlternateContactPhoneNumber { get; set; }
        public string AlternateContactPhoneLocation { get; set; }
        public string BriefDescription { get; set; }
        public string Reference { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public string ServiceOrderType { get; set; }
        public string System { get; set; }
        public string WorkRequested { get; set; }
        public string WorkPerformed { get; set; }
        public string PaymentMethod { get; set; }
        public string ShippingMethod { get; set; }
        public string InternalComments { get; set; }
        public string DirectionsToLocation { get; set; }
        public string CustomerPurchaseOrder { get; set; }
        public string VerifiedBy { get; set; }
        public string ServiceZone { get; set; }
        public string RequestedBy { get; set; }
        public string TagNumber { get; set; }
        public string LoanAgreement { get; set; }
        public string DebitCreditMemo { get; set; }
        public string InvoiceTerms { get; set; }
        public string FreightTerms { get; set; }
        public string SalesTaxCode { get; set; }
        public DateTime DateTimeReceived { get; set; }
        public DateTimeRequested DateTimeRequested { get; set; }
        public DateTimeOpened DateTimeOpened { get; set; }
        public DateTimeClosed DateTimeClosed { get; set; }
        public VerifiedDate VerifiedDate { get; set; }
        public bool ResolvedOnPhone { get; set; }
        public int BidPrice { get; set; }
        public int TradeIn { get; set; }
        public int Deposit { get; set; }
        public int Freight { get; set; }
        public string BillToAddressType { get; set; }
        public int BillToAddressAccountNumber { get; set; }
        public BillTo BillTo { get; set; }
        public string ShipToAddressType { get; set; }
        public int ShipToAddressAccountNumber { get; set; }
        public ShipTo ShipTo { get; set; }
        public bool UseAlternateShipToTaxCode { get; set; }
        public bool CanReassignToHourlyUsageContractAlreadyInvoiced { get; set; }
        public bool CanUpdateContractMeterReadingToServiceOrderReading { get; set; }
        public bool AllowInactiveContract { get; set; }
        public bool AllowFutureContract { get; set; }
        public bool AllowContractNoRemaining { get; set; }
        public bool UseContractDefaultTech { get; set; }
        public bool DisplayOnCustomerPortal { get; set; }
    }

    public class DateTimeRequested
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }

    public class DateTimeOpened
    {
        public DateTime DateTime { get; set; }
    }

    public class DateTimeClosed
    {
        public DateTime DateTime { get; set; }
    }

    public class VerifiedDate
    {
        public DateTime DateTime { get; set; }
    }

    public class BillTo
    {
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
    }

    public class ShipTo
    {
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
    }
}
