using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class CountryView
    {
        public int Key { get; set; }
        public bool IsActive { get; set; }

        public int CountryRef { get; set; }
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
    }
}
