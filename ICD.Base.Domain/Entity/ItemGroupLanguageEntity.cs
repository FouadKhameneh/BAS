using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class ItemGroupLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Properties
        public int ItemGroupRef { get; set; }
        public ItemGroupEntity ItemGroup { get; set; }
        #endregion
    }
}
