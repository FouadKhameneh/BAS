using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class InsertGLNRequest : Request<InsertGLNResult>
    {
        public long PersonRef { get; set; }
        public string GLN { get; set; }

        public string _Title { get; set; }
        public string _Address { get; set; }
    }

    public class InsertGLNResult : SingleQueryResult<InsertGLNModel> { }

    public class InsertGLNModel
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
