using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblQuoteQuickPick
    {
        public int QuickPickId { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string ControlParent { get; set; }
        public string Value { get; set; }
    }
}
