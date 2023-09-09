using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class ItemRowEntity : BaseEntity<int>
    {
        public string Alias { get; set; }
        public bool IsActive { get; set; }
        public string Value { get; set; }

        #region Navigation Properties
        public int ItemGroupRef { get; set; }
        public ItemGroupEntity ItemGroup { get; set; }

        public ICollection<PersonTitleEntity> PersonTitles { get; set; }
        public ICollection<ItemRowLanguageEntity> ItemRowLanguages { get; set; }
        public ICollection<PersonIdentityEntity> PersonIdentities { get; set; }
        #endregion
    }
}
