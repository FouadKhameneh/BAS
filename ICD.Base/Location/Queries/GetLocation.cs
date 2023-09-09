using ICD.Framework.Model;

namespace ICD.Base
{
    public class GetLocationQuery : Query
    {
        public int? ParentRef { get; set; }
        public string Alias { get; set; }
    }

    public class GetLocationResult : ListQueryResult<GetLocationModel> { }
    public class GetLocationModel
    {
        public int Key { get; set; }
        public int LocationTypeRef { get; set; }
        public int? ParentRef { get; set; }
        public int LevelNo { get; set; }
        public bool IsActive { get; set; }

        public string _Name { get; set; }

        public string Alias { get; set; }
    }
}
