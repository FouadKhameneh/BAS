using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class LocationTypeEntity : BaseEntity<int>
    {
        public string Alias { get; set; }

        #region Navigation Properties
        public ICollection<LocationTypeLanguageEntity> LocationTypeLanguages { get; set; }
        public ICollection<LocationEntity> Locations { get; set; }
        #endregion
    }
}
