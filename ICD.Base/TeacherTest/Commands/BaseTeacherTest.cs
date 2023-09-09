using ICD.Framework.Model;

namespace ICD.Base;


    public class BaseTeacherTest : Request<BaseTeacherTestResult>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Point { get; set; }
    }
    
    public class BaseTeacherTestResult : SingleQueryResult<BaseTeacherTestModel> { }
    
    public class BaseTeacherTestModel 
    {
    }
