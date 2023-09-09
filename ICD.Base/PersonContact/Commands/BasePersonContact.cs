using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BasePersonContact : Request<BasePersonContactResult>
    {
        public long PersonRef { get; set; }
        public ICollection<ContactModel> Contacts { get; set; }
    }

    public class BasePersonContactResult : SingleQueryResult<BasePersonContactModel>
    {
    }

    public class BasePersonContactModel
    {
    }
    public class ContactModel
    {
        public string ContactInfo { get; set; }
        public bool IsMain { get; set; }
        public int ContactTypeRef { get; set; }
    }
}
