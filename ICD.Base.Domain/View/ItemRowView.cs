using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class ItemRowView
    {
        public int Key { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }
        public int ItemGroupRef { get; set; }
        public string Value { get; set; }

        public string _Title { get; set; }
        public int ItemRowRef { get; set; }

        public int ApplicationRef { get; set; }
        public string ItemGroupAlias { get; set; }
        public bool ItemGroupIsActive { get; set; }
    }
}
