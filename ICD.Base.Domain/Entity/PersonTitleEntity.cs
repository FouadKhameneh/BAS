using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class PersonTitleEntity : BaseEntity<int>
    {
        public int Order { get; set; }
        public bool IsLegal { get; set; }
        public bool IsActive { get; set; }
        public string Alias { get; set; }

        #region Navigation Properties
        public int ItemRowRef_LegalType { get; set; }
        public ItemRowEntity ItemRow { get; set; }

        public ICollection<PersonEntity> Persons { get; set; }
        public ICollection<PersonTitleLanguageEntity> PersonTitleLanguages { get; set; }
        #endregion
    }
}
