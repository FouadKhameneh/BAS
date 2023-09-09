using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class GLNCoView
    {
        public long Key { get; set; }
        public long PersonRef { get; set; }
        public string GLN { get; set; }

        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Address { get; set; }

        public string GLN_TitleGLN { get; set; }

        public short CompanyKey { get; set; }
        public string Company_Title { get; set; }
    }
}
