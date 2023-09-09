using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class InsertListGlnRequest : Request<InsertListGlnResult>
    {
        public long PersonRef { get; set; }
        public ICollection<InsertListGlnDetailModel> Details { get; set; }
    }
    public class InsertListGlnResult : SingleQueryResult<InsertListGlnModel> { }
    public class InsertListGlnModel { }
    public class InsertListGlnDetailModel
    {
        public string GLN { get; set; }

        public string _Title { get; set; }
        public string _Address { get; set; }
    }
}
