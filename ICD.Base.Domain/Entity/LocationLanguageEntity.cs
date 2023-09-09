using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class LocationLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Name { get; set; }

        #region Navigation Properties
        public int LocationRef { get; set; }
        public LocationEntity Location { get; set; }
        #endregion
    }
}
