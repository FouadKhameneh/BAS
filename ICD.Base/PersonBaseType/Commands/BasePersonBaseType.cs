using ICD.Framework.Model;

namespace ICD.Base
{
    public class BasePersonBaseType : Request<BasePersonBaseTypeResult>
    {
        public int BaseTypeRef { get; set; }
        public long PersonRef { get; set; }
    }
    public class BasePersonBaseTypeResult : SingleQueryResult<BasePersonBaseTypeModel> { }
    public class BasePersonBaseTypeModel { }
}
