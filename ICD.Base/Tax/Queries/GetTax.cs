using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetTaxByKeyQuery : Query
    {
        public int Key { get; set; }
    }
    public class GetTaxByKeyResult : SingleQueryResult<GetTaxModel>
    {
    }

    public class GetTaxQuery : Query
    {
    }
    public class GetTaxResult : ListQueryResult<GetTaxModel> { }
    public class GetTaxModel
    {
        public int Key { get; set; }
        public decimal TaxPercent { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public long TaxRef { get; set; }
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }
    }
}
