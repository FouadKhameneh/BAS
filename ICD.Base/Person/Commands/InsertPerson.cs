using ICD.Framework.Model;

namespace ICD.Base
{
    public class InsertPersonRequest : Request<InsertPersonResult> 
    {
        public string NationalIdentity { get; set; }
        public string EconomicId { get; set; }
        public int PersonTitleRef { get; set; }

        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string _FatherName { get; set; }
    }

    public class InsertPersonResult : SingleQueryResult<InsertPersonModel> { }

    public class InsertPersonModel
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
