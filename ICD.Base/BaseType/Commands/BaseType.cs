using ICD.Framework.Model;

namespace ICD.Base
{
    public class BaseType : Request<BaseTypeResult>
    {
        public string Alias { get; set; }
        public long PersonRef { get; set; }
    }
    public class BaseTypeResult : SingleQueryResult<BaseTypeModel> { }
    public class BaseTypeModel { }
}
