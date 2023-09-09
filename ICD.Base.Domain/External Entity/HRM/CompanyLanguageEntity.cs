using ICD.Framework.Domain;

namespace ICD.Base.Domain.External_Entity.HRM
{
    public class CompanyLanguageEntity : BaseEntity<long>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Properties
        public short CompanyRef { get; set; }
        public CompanyEntity Company { get; set; }
        #endregion
    }
}
