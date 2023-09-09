using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class DeleteTypeByteRequest : Request<DeleteTypeByteResult>
    {
        public byte Key { get; set; }
    }

    public class DeleteTypeByteResult : SingleQueryResult<DeleteTypeByteModel> { }
    public class DeleteTypeByteModel { }
}
