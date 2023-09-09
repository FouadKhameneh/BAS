using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class CountryEntity : BaseEntity<int>
    {
        public bool IsActive { get; set; }

        #region Navigation Prop
        public ICollection<CountryLanguageEntity> CountryLanguages { get; set; }
        public ICollection<CityEntity> Cities { get; set; }
        #endregion
    }
}
