using ICD.Framework.Model;

namespace ICD.Base
{
    public class GetItemRowsQuery : Query
    {
        public int? ItemGroupRef { get; set; }
        public string ItemGroupAlias { get; set; }
    }

    public class GetItemRowsResult : ListQueryResult<GetItemRowsModel> { }
    public class GetItemRowsModel
    {
        public int Key { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }
        public int ItemGroupRef { get; set; }
        public string Value { get; set; }

        public string _Title { get; set; }
    }
}
