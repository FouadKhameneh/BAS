using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class ContactTypeView
    {
        public int Key { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public int LanguageRef { get; set; }
        public int ContactTypeRef { get; set; }
        public string _Title { get; set; }
    }
}
