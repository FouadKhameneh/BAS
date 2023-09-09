using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class PersonTitleLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Name { get; set; }
        public string _Description { get; set; }

        #region Navigation Properties
        public int PersonTitleRef { get; set; }
        public PersonTitleEntity PersonTitle { get; set; }
        #endregion
    }
}
