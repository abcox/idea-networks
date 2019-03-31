using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteDatabaseUserLog
    {
        public int LogId { get; set; }
        public string UserId { get; set; }
        public string UserAction { get; set; }
        public DateTime? TimeOccured { get; set; }
        public int? Loginid { get; set; }
    }
}
