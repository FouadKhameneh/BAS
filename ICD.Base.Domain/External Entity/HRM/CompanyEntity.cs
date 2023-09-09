using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.External_Entity.HRM
{
    public class CompanyEntity : BaseEntity<short>
    {
        public int Code { get; set; }
        public long TotalCode { get; set; }
        public bool IsActive { get; set; }
        public string Prefix { get; set; }
        public string Abbreviation { get; set; }

        #region Navigation Properties
        public long PersonRef { get; set; }

        public short? ParentRef { get; set; }
        public CompanyEntity Company { get; set; }

        public ICollection<CompanyEntity> Companies { get; set; }
        public ICollection<CompanyLanguageEntity> CompanyLanguages { get; set; }
        #endregion
    }
}
