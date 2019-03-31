﻿using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteInternalComments
    {
        public int Id { get; set; }
        public byte[] Ts { get; set; }
        public int? QuoteId { get; set; }
        public string InternalComment { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Createdon { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modifiedon { get; set; }
    }
}
