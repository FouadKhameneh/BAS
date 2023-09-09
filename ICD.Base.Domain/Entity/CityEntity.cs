using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Domain.Entity
{
    public class CityEntity : BaseEntity<int>
    {
        public bool IsActive { get; set; }

        #region Navigation Prop
        public int CountryRef { get; set; }
        public CountryEntity Country { get; set; }

        public ICollection<CityLanguageEntity> CityLanguages { get; set; }
        #endregion
    }
}
