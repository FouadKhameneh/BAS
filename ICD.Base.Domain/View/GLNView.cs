using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class GLNView
    {
        public long Key { get; set; }
        public long PersonRef { get; set; }
        public string GLN { get; set; }

        public long GLNLanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Address { get; set; }

        public string FullName { get; set; }
    }
}
