using ICD.Framework.Model;

namespace ICD.Base
{
    public class BaseItemGroup : Request<BaseItemGroupResult>
    {
        public int ApplicationRef { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public string _Title { get; set; }
    }
    public class BaseItemGroupResult : SingleQueryResult<BaseItemGroupModel> { }
    public class BaseItemGroupModel { }
}
