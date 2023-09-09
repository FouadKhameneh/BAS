using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class ItemRowByKeyView
    {
        public int Key { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }
        public int ItemGroupRef { get; set; }
        public string Value { get; set; }

        public int ItemRowLanguageKey { get; set; }
        public string _Title { get; set; }
    }
}
