﻿using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblCustomersSecurity
    {
        public int SecurityId { get; set; }
        public string FunctionName { get; set; }
        public string Groups { get; set; }
    }
}
