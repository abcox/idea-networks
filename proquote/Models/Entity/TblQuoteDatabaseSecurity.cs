using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblQuoteDatabaseSecurity
    {
        public int SecurityId { get; set; }
        public string FunctionName { get; set; }
        public string Groups { get; set; }
    }
}
