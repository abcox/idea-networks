﻿using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteDatabaseSecurity
    {
        public int SecurityId { get; set; }
        public string FunctionName { get; set; }
        public string Groups { get; set; }
    }
}
