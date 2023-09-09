using ICD.Framework.Domain;

namespace ICD.Base.Domain.Entity
{
    public class PersonBaseTypeEntity : BaseEntity<int>
    {
        #region Navigation Properties
        public int BaseTypeRef { get; set; }
        public BaseTypeEntity BaseType { get; set; }

        public long PersonRef { get; set; }
        public PersonEntity Person { get; set; }
        #endregion
    }
}
