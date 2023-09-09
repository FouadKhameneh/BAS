using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class CostTypeTaxView
    {
        public long Key { get; set; }
        public decimal TaxPercent { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }

        public short? CostTypeRef { get; set; }
        public long? TaxRef { get; set; }
    }
}
