using ICD.Framework.Model;

namespace ICD.Base
{
    public class BaseLocation : Request<BaseLocationResult>
    {
        public int LocationTypeRef { get; set; }
        public int? ParentRef { get; set; }
        public int LevelNo { get; set; }
        public bool IsActive { get; set; }

        public string _Name { get; set; }
    }
    public class BaseLocationResult : SingleQueryResult<BaseLocationModel> { }
    public class BaseLocationModel { }
}
