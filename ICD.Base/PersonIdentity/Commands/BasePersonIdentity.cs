using ICD.Framework.Model;
using System;

namespace ICD.Base
{
    public class BasePersonIdentity : Request<BasePersonIdentityResult>
    {
        public int ItemRowRef_IdentityType { get; set; }
        public string FirstIdNo { get; set; }
        public string SecondIdNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? LocationRef_BirthLocation { get; set; }
        public DateTime? BirthDate { get; set; }
        public int LocationRef_IssuePlace { get; set; }

        public long PersonRef { get; set; }
    }
    public class BasePersonIdentityResult : SingleQueryResult<BasePersonIdentityModel> { }
    public class BasePersonIdentityModel { }
}
