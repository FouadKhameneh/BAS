using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseCostTypeTax : Request<BaseCostTypeTaxResult>
    {
        public short CostTypeRef { get; set; }
        public List<int> TaxRefs { get; set; }
    }

    public class BaseCostTypeTaxResult : SingleQueryResult<BaseCostTypeTaxModel>
    {
    }

    public class BaseCostTypeTaxModel
    {
    }
}
