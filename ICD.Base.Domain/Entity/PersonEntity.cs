using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class PersonEntity : BaseEntity<long>
    {
        public string NationalIdentity { get; set; }
        public string EconomicId { get; set; }

        #region Navigation Properties
        public int PersonTitleRef { get; set; }
        public PersonTitleEntity PersonTitle { get; set; }

        public ICollection<PersonLanguageEntity> PersonLanguages { get; set; }
        public ICollection<PersonBaseTypeEntity> PersonBaseTypes { get; set; }
        public ICollection<PersonIdentityEntity> PersonIdentities { get; set; }
        public ICollection<PersonContactEntity> PersonContacts { get; set; }
        public ICollection<SanaSupportInfoEntity> SanaSupportInfos { get; set; }
        #endregion
    }
}
