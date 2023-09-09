using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class ExpenseCenterView
    {
        public long Key { get; set; }
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
    }
}
