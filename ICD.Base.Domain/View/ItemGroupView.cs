using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class ItemGroupView
    {
        //item group

        public int Key { get; set; }
        public int ApplicationRef { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        //item group language

        public string _Title { get; set; }
        public int ItemGroupRef { get; set; }
    }
}
