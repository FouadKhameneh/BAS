using ICD.Framework.Model;

namespace ICD.Base
{
    public class GetPersonTitlesQuery : Query
    {
        public bool? IsActive { get; set; }
        public bool? IsLegal { get; set; }
    }

    public class GetPersonTitlesResult : ListQueryResult<GetPersonTitlesModel> { }
    public class GetPersonTitlesModel
    {
        public int Key { get; set; }
        public bool IsLegal { get; set; }
        public bool IsActive { get; set; }
        public string Alias { get; set; }
        public int Order { get; set; }
        public int ItemRowRef_LegalType { get; set; }
        public string ItemRowAlias { get; set; }

        public string _Name { get; set; }
        public string _Description { get; set; }
    }
}
