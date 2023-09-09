using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class LocationTypeLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Properties
        public int LocationTypeRef { get; set; }
        public LocationTypeEntity LocationType { get; set; }
        #endregion
    }
}
