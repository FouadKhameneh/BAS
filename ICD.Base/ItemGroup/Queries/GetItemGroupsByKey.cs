using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetItemGroupsByKeyQuery : Query
    {
        public int Key { get; set; }
    }

    public class GetItemGroupsByKeyResult : SingleQueryResult<GetItemGroupsByKeyModel> { }
    public class GetItemGroupsByKeyModel
    {
        public int Key { get; set; }
        public int ApplicationRef { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public string _Title { get; set; }
    }
}
