using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class DeleteTypeShortRequest : Request<DeleteTypeShortResult>
    {
        public short Key { get; set; }
    }

    public class DeleteTypeShortResult : SingleQueryResult<DeleteTypeShortModel> { }
    public class DeleteTypeShortModel { }
}
