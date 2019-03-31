using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblWebLicenses
    {
        public int LogId { get; set; }
        public string Usercode { get; set; }
        public DateTime? Timeoccured { get; set; }
        public int? Numberloggedin { get; set; }
        public string Usersloggedin { get; set; }
        public byte[] Ts { get; set; }
    }
}
