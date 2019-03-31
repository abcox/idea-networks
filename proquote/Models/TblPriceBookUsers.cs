using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblPriceBookUsers
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string UserCode { get; set; }
        public string UserTitle { get; set; }
        public string UserAddress { get; set; }
        public string UserPhone { get; set; }
        public string UserFax { get; set; }
        public string UserEmail { get; set; }
        public string Groups { get; set; }
    }
}
