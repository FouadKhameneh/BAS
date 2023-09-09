using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class PersonTitleView
    {
        //person title
        public int Key { get; set; }
        public bool IsLegal { get; set; }
        public bool IsActive { get; set; }
        public string Alias { get; set; }
        public int Order { get; set; }
        public int ItemRowRef_LegalType { get; set; }

        //person title language

        public string _Name { get; set; }
        public string Description { get; set; }

        public string ItemRowAlias { get; set; }
    }
}
