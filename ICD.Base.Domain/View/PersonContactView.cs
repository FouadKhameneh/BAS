using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class PersonContactView
    {
        public int Key { get; set; }
        public string ContactInfo { get; set; }
        public bool IsMain { get; set; }
        public long PersonRef { get; set; }
        public int ContactTypeRef { get; set; }
        public string _ContactTypeTitle { get; set; }
    }
}
