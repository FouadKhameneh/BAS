using ICD.Framework.Domain;
using System;

namespace ICD.Base.Domain.Entity
{
    public class PersonLanguageEntity : BaseEntity<long>
    {
        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string _FatherName { get; set; }
        public int LanguageRef { get; set; }
        public string FullName { get; set; }

        #region Navigation Properties
        public long PersonRef { get; set; }
        public PersonEntity Person { get; set; }
        #endregion
    }
}
