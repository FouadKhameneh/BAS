using ICD.Framework.Domain;
using System;

namespace ICD.Base.Domain.Entity
{
    public class PersonIdentityEntity : BaseEntity<int>
    {
        public string FirstIdNo { get; set; }
        public string SecondIdNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? BirthDate { get; set; }

        #region Navigation Properties
        public long PersonRef { get; set; }
        public PersonEntity Person { get; set; }

        public int ItemRowRef_IdentityType { get; set; }
        public ItemRowEntity ItemRow { get; set; }

        public int LocationRef_IssuePlace { get; set; }
        public LocationEntity IssuePlace { get; set; }

        public int? LocationRef_BirthLocation { get; set; }
        public LocationEntity BirthLocation { get; set; }
        #endregion
    }
}
