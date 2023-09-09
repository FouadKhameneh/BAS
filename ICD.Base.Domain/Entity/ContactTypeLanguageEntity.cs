using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class ContactTypeLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Props
        public int ContactTypeRef { get; set; }
        public ContactTypeEntity ContactType { get; set; }
        #endregion
    }
}
