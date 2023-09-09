using ICD.Framework.Domain;
using System.Collections.Generic;

namespace ICD.Base.Domain.Entity
{
    public class ExpenseCenterEntity : BaseEntity<long>
    {
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }

        #region Navigation Property
        public ICollection<ExpenseCenterLanguageEntity> ExpenseCenterLanguages { get; set; }
        #endregion
    }
}
