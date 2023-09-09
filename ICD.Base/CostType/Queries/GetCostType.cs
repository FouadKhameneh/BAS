using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetCostTypeQuery : Query
    {
        public short CompanyRef { get; set; }
    }

    public class GetCostTypeResult : ListQueryResult<GetCostTypeModel> { }

    public class GetCostTypeModel
    {
        public short Key { get; set; }
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }
        public int ItemRowRef_CostOrigin { get; set; }
        public string ItemRowRef_CostOriginTitle { get; set; }
        public int ItemRowRef_SharingType { get; set; }
        public int CostSign { get; set; }
        public string ItemRow_SharingTypeTitle { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }
        public decimal? SumTaxPercent { get; set; }
    }
}
