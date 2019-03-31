using System;
using System.Collections.Generic;

namespace proquote.Models
{
    public partial class TblWebProperties
    {
        public int PropertiesId { get; set; }
        public int? Maxsearchresult { get; set; }
        public int? MaxRfq { get; set; }
        public int? MaxQuote { get; set; }
        public int? Maxorders { get; set; }
        public int? Maxopenorders { get; set; }
        public int? Maxsession { get; set; }
    }
}
