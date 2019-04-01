using System;
using System.Collections.Generic;

namespace proquote.Models.Entity
{
    public partial class TblPriceBookSections
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OrderId { get; set; }
        public bool? Selected { get; set; }
        public int? ParentId { get; set; }
        public string Footer { get; set; }
        public string Fullpath { get; set; }
        public string ProductsGroup { get; set; }
        public byte[] Ts { get; set; }
    }
}
