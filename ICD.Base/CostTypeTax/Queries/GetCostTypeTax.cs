using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetCostTypeTaxQuery : Query
    {
        public short CostTypeRef { get; set; }
    }
    public class GetCostTypeTaxResult : ListQueryResult<GetCostTypeTaxModel> { }

    public class GetCostTypeTaxModel
    {
        public int Key { get; set; }
        public decimal TaxPercent { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }

        public short? CostTypeRef { get; set; }
        public int? TaxRef { get; set; }
    }
}
