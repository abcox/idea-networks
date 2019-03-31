using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteDatabaseSalesGroups
    {
        public int SalesGroupId { get; set; }
        public string SalesGroup { get; set; }
        public string Description { get; set; }
        public string CsruserCode { get; set; }
        public string SruserCode { get; set; }
        public string SupportUserCode { get; set; }
    }
}
