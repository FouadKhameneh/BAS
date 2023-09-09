using ICD.Framework.Domain;

namespace ICD.Base.Domain.External_Entity.INF
{
    public class ApplicationLanguageEntity : BaseEntity<long>
    {
        public string _Title { get; set; }

        #region  Navigation Props
        public long ApplicationRef { get; set; }
        public ApplicationEntity Application { get; set; }

        public int LanguageRef { get; set; }
        #endregion
    }
}