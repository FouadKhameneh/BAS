using ICD.Framework.Model;
using System.Collections;
using System.Collections.Generic;

namespace ICD.Base
{
    public class GetPeopleBySpecificationQuery : Query
    {
        public int? PersonTitleRef { get; set; }
        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string NationalIdentity { get; set; }
        public bool? IsLegal { get; set; }
        public ICollection<string> BaseTypeAliases { get; set; }
    }

    public class GetPeopleByspecificationResult : ListQueryResult<GetPeopleByspecificationModel> { }

    public class GetPeopleByspecificationModel
    {
        public int Key { get; set; }
        public string NationalIdentity { get; set; }
        public string EconomicId { get; set; }
        public int PersonTitleRef { get; set; }


        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string _FatherName { get; set; }
        public string FullName { get; set; }

        public int Order { get; set; }
        public bool IsLegal { get; set; }
        public bool IsActive { get; set; }
        public string Alias { get; set; }

        public string _PersonTitleName { get; set; }

        public string BaseTypeAlias { get; set; }
    }
}
