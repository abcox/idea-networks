using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblCustomersProperties
    {
        public int PropertiesId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Description { get; set; }
        public string Administrator { get; set; }
        public string Password { get; set; }
    }
}
