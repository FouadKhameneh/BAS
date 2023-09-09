using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class CostTypeView
    {
        public short Key { get; set; }
        public bool IsActive { get; set; }
        public int CostSign { get; set; }
        public short CompanyRef { get; set; }
        public int ItemRowRef_CostOrigin { get; set; }
        public string ItemRowRef_CostOriginTitle { get; set; }
        public int ItemRowRef_SharingType { get; set; }
        public string ItemRow_SharingTypeTitle { get; set; }

        public string _Title { get; set; }
        public string _Description { get; set; }


        public long? TaxRef { get; set; }
        public decimal? TaxPercent { get; set; }
        public string TaxAlias { get; set; }
        public bool? TaxIsActive { get; set; }
    }
}
