using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class TaxEntity : BaseEntity<int>
    {
        public decimal TaxPercent { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        #region Navigation Prop
        public ICollection<TaxLanguageEntity> TaxLanguages { get; set; }
        public ICollection<CostTypeTaxEntity> CostTypeTaxes { get; set; }
        #endregion
    }
}
