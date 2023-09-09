using ICD.Framework.Model;

namespace ICD.Base
{
    public class BasePersonTitle : Request<BasePersonTitleResult>
    {
        public int Order { get; set; }
        public string ItemRowAlias { get; set; }
        public bool IsActive { get; set; }
        public string Alias { get; set; }
        public int ItemRowRef_LegalType { get; set; }

        public string _Name { get; set; }
        public string _Description { get; set; }
    }

    public class BasePersonTitleResult : SingleQueryResult<BasePersonTitleModel> { }
    public class BasePersonTitleModel { }
}
