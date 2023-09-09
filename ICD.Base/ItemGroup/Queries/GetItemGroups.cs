using ICD.Framework.Model;

namespace ICD.Base
{
    public class GetItemGroupsQuery : Query
    {
        public int? ApplicationRef { get; set; }
        public bool? IsActive { get; set; }
    }

    public class GetItemGroupsResult : ListQueryResult<GetItemGroupsModel> { }
    public class GetItemGroupsModel
    {
        public int Key { get; set; }
        public int ApplicationRef { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public string _Title { get; set; }
    }
}
