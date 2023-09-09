using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class DeleteItemRowRequest : Request<DeleteItemRowResult>
    {
        public ICollection<int> Keys { get; set; }
    }
    public class DeleteItemRowResult : SingleQueryResult<DeleteItemRowModel> { }
    public class DeleteItemRowModel { }
}
