using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class BaseTypeEntity : BaseEntity<int>
    {
        public string Alias { get; set; }

        #region Navigation Properties
        public ICollection<PersonBaseTypeEntity> personBaseTypes { get; set; }
        #endregion
    }
}
