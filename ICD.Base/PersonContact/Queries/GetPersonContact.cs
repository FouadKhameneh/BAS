using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetPersonContactQuery : Query
    {
        public long PersonRef { get; set; }
    }
    public class GetPersonContactResult : ListQueryResult<GetPersonContactModel> { }

    public class GetPersonContactModel
    {
        public int Key { get; set; }
        public string ContactInfo { get; set; }
        public bool IsMain { get; set; }
        public int ContactTypeRef { get; set; }
        public string _ContactTypeTitle { get; set; }
    }
}
