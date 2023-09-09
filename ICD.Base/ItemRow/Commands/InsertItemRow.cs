using ICD.Framework.Model;
using System.Collections.Generic;

namespace ICD.Base
{
    public class InsertItemRowRequest : Request<InsertItemRowResult>
    {
        public int ItemGroupRef { get; set; }
        public ICollection<ItemRowFieldModel> Details { get; set; }
    }
    public class InsertItemRowResult : SingleQueryResult<InsertItemRowModel> { }
    public class InsertItemRowModel { }
    public class ItemRowFieldModel
    {
        public int? Key { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }
        public string Value { get; set; }

        public string _Title { get; set; }
    }
}
