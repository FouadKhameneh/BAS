using ICD.Framework.Model;

namespace ICD.Base
{
    public class InsertItemGroupRequest : BaseItemGroup { }

    public class InsertItemGroupResult : SingleQueryResult<InsertItemGroupModel> { }

    public class InsertItemGroupModel
    {
        public int Key { get; set; }
        public int ApplicationRef { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public string _Title { get; set; }
    }
}
