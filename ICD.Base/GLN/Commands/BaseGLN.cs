using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseGLN : Request<BaseGLNResult>
    {
        public long PersonRef { get; set; }
        public string GLN { get; set; }

        public string _Title { get; set; }
        public string _Address { get; set; }
    }

    public class BaseGLNResult : SingleQueryResult<BaseGLNModel>
    {
    }

    public class BaseGLNModel
    {
    }
}
