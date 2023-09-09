using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class PersonContactEntity : BaseEntity<int>
    {
        public string ContactInfo { get; set; }
        public bool IsMain { get; set; }

        #region Navigation Props
        public long PersonRef { get; set; }
        public PersonEntity Person { get; set; }

        public int ContactTypeRef { get; set; }
        public ContactTypeEntity ContactType { get; set; }
        #endregion
    }
}
