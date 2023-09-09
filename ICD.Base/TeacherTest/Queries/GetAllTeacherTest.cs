using ICD.Framework.Model;

namespace ICD.Base;

public class GetAllTeacherTestsQuery : Query
{
}
public class GetAllTeacherTestsResult : ListQueryResult<GetAllTeacherTestsModel> { }
public class GetAllTeacherTestsModel
{
    public int Key { get; set; }
    public string FirstName { get; set; }
    public int Point { get; set; }
}