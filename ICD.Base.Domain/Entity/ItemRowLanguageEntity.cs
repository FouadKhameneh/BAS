using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class ItemRowLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Properties
        public int ItemRowRef { get; set; }
        public ItemRowEntity ItemRow { get; set; }
        #endregion
    }
}
