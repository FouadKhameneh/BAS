using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetGLNQuery : Query
    {
        public long? PersonRef { get; set; }
    }

    public class GetGLNResult : ListQueryResult<GetGLNModel> { }

    public class GetGLNModel
    {
        public long Key { get; set; }
        public long PersonRef { get; set; }
        public string GLN { get; set; }

        public long GLNLanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Address { get; set; }

        public string FullName { get; set; }
    }
}
