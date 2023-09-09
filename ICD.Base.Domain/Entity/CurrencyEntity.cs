using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class CurrencyEntity : BaseEntity<byte>
    {
        public bool IsActive { get; set; }
        public bool IsNational { get; set; }
        public string Icon { get; set; }

        #region Navigation Prop
        public ICollection<CurrencyLanguageEntity> CurrencyLanguages { get; set; }
        #endregion
    }
}
