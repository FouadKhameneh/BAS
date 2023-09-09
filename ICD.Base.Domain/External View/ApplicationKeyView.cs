using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.External_View
{
    public class ApplicationKeyView
    {
        public long ApplicationKey { get; set; }
        public long ApplicationTableKey { get; set; }

        public string Alias { get; set; }
        public string Name { get; set; }
    }
}
