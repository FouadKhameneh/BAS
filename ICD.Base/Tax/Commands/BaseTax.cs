using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseTax : Request<BaseTaxResult>
    {
        public decimal TaxPercent { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public string _Title { get; set; }
        public string _Description { get; set; }
    }
    public class BaseTaxResult : SingleQueryResult<BaseTaxModel> { }
    public class BaseTaxModel { }
}
