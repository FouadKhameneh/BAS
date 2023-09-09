using ICD.Framework.Model;

namespace ICD.Base
{
    public class GetBaseTypeKeyByAliasQuery : Query
    {
        public string Alias { get; set; }
    }
    public class GetBaseTypeKeyByAliasResult : SingleQueryResult<GetBaseTypeKeyByAliasModel> { }
    public class GetBaseTypeKeyByAliasModel
    {
        public int BaseTypeKey { get; set; }
    }
}
