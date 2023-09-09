using ICD.Framework.Model;

namespace ICD.Base
{
    public class GetExpenseCentersQuery : Query
    {
        public short? CompanyRef { get; set; }
        public bool? IsActive { get; set; }
    }
    public class GetExpenseCentersResult : ListQueryResult<GetExpenseCenterModel>
    {

    }
    public class GetExpenseCenterModel
    {
        public long Key { get; set; }
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }

        public int LanguageRef { get; set; }
        public string _Title { get; set; }
    }
}
