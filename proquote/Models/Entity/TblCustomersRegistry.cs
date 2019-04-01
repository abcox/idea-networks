using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblCustomersRegistry
    {
        public int RegistryId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Format { get; set; }
        public string DefaultValue { get; set; }
        public bool? ShowInGrid { get; set; }
        public bool? IsCost { get; set; }
        public bool? IsRequired { get; set; }
        public bool? IsStandard { get; set; }
        public int? OrderId { get; set; }
        public bool? UseInCalc { get; set; }
        public bool? IsPrice { get; set; }
        public bool? SpellCheck { get; set; }
        public string ControlType { get; set; }
        public string ControlSource { get; set; }
        public string Controllabel { get; set; }
        public bool? ShowInWebGrid { get; set; }
        public bool? ShowInWebDetail { get; set; }
        public string WebDefaultValue { get; set; }
        public string GridLabel { get; set; }
        public string DetailLabel { get; set; }
        public int? DetailOrderId { get; set; }
        public string WebType { get; set; }
        public string Weblink { get; set; }
        public string WebParamNames { get; set; }
        public string WebParamValues { get; set; }
        public string WebParamTarget { get; set; }
        public string ColnWidth { get; set; }
        public string ColnAlign { get; set; }
        public string DetailWebType { get; set; }
        public string DetailWeblink { get; set; }
        public string DetailWebParamNames { get; set; }
        public string DetailWebParamValues { get; set; }
        public string DetailWebParamTarget { get; set; }
        public string DetailRowWidth { get; set; }
        public string DetailRowAlign { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? DetailIsRequired { get; set; }
        public bool? IsRule { get; set; }
    }
}
