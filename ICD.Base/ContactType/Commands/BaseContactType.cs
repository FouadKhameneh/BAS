using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseContactType : Request<BaseContactTypeResult>
    {
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public string _Title { get; set; }
    }

    public class BaseContactTypeResult : SingleQueryResult<BaseContactTypeModel>
    {
    }

    public class BaseContactTypeModel
    {
    }
}
