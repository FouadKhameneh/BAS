using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class LocationEntity : BaseEntity<int>
    {
        public int LevelNo { get; set; }
        public bool IsActive { get; set; }

        #region Navigation Properties
        public int? ParentRef { get; set; }
        public LocationEntity Location { get; set; }

        public int LocationTypeRef { get; set; }
        public LocationTypeEntity LocationType { get; set; }

        public ICollection<PersonIdentityEntity> BirthLocationPersonIdentities { get; set; }
        public ICollection<PersonIdentityEntity> IssuePlacePersonIdentities { get; set; }
        public ICollection<LocationLanguageEntity> LocationLanguages { get; set; }
        public ICollection<LocationEntity> Locations { get; set; }
        #endregion
    }
}
