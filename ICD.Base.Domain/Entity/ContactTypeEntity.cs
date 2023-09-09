using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class ContactTypeEntity : BaseEntity<int>
    {
        public string Alias { get; set; }
        public bool IsActive { get; set; }
        #region Navigation Props
        public ICollection<ContactTypeLanguageEntity> ContactTypeLanguages { get; set; }
        public ICollection<PersonContactEntity> PersonContacts { get; set; }
        #endregion
    }
}
