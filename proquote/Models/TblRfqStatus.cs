﻿using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblRfqStatus
    {
        public int StatusId { get; set; }
        public int? QuoteId { get; set; }
        public string Status { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public string Reason { get; set; }
        public byte[] Ts { get; set; }
    }
}