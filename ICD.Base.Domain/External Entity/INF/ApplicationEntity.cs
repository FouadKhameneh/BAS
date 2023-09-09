using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ICD.Framework.Domain;

namespace ICD.Base.Domain.External_Entity.INF
{
    public class ApplicationEntity : BaseEntity<long>
    {
        [StringLength(100)]
        public string Alias { get; set; }

        [StringLength(100)]
        public string Url { get; set; }

        [StringLength(10)]
        public string Abbreviation { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        public int Order { get; set; }

        public bool IsActive { get; set; } = true;
        public int ApplicationTypeRef { get; set; }

        #region  Navigation Props
        public ICollection<ApplicationLanguageEntity> ApplicationLanguages { get; set; }
        public ICollection<ApplicationTableEntity> ApplicationTables { get; set; }
        #endregion
    }
}