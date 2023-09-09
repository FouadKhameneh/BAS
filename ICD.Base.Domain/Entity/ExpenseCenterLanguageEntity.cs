using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class ExpenseCenterLanguageEntity : BaseEntity<long>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Property
        public long ExpenseCenterRef { get; set; }
        public ExpenseCenterEntity ExpenseCenter { get; set; }
        #endregion
    }
}
