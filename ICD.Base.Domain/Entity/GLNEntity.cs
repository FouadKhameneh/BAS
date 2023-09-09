using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class GLNEntity : BaseEntity<long>
    {
        public long PersonRef { get; set; }
        public string GLN { get; set; }

        #region Navigation Props
        public ICollection<GLNLanguageEntity> GLNLanguages { get; set; }
        #endregion
    }
}
