using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblQuoteDatabaseStatus
    {
        public int Id { get; set; }
        public int? StatusOrder { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Group { get; set; }
        public bool? SendEmail { get; set; }
    }
}
