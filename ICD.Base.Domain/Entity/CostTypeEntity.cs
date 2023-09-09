using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class CostTypeEntity : BaseEntity<short>
    {
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }
        public int ItemRowRef_CostOrigin { get; set; }
        public int ItemRowRef_SharingType { get; set; }
        public int CostSign { get; set; }

        #region Navigation Props
        public ICollection<CostTypeLanguageEntity> CostTypeLanguages { get; set; }
        public ICollection<CostTypeTaxEntity> CostTypeTaxes { get; set; }
        #endregion
    }
}
