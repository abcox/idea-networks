using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblPriceBookRule
    {
        public int RuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RuleText { get; set; }
        public string RuleField { get; set; }
    }
}
