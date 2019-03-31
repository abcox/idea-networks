using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteDatabaseReg
    {
        public int RegistrationId { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public byte[] Logo { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
