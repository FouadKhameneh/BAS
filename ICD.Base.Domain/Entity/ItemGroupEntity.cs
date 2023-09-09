using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class ItemGroupEntity : BaseEntity<int>
    {
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        #region Navigation Properties
        public int ApplicationRef { get; set; }

        public ICollection<ItemGroupLanguageEntity> ItemGroupLanguages { get; set; }
        public ICollection<ItemRowEntity> ItemRows { get; set; }
        #endregion
    }
}
