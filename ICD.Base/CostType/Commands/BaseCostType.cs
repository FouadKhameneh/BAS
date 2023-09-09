using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseCostType : Request<BaseCostTypeResult>
    {
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }
        public int ItemRowRef_CostOrigin { get; set; }
        public int ItemRowRef_SharingType { get; set; }
        public int CostSign { get; set; }

        public string _Title { get; set; }
        public string _Description { get; set; }
    }

    public class BaseCostTypeResult : SingleQueryResult<BaseCostTypeModel>
    {
    }

    public class BaseCostTypeModel
    {
    }
}
