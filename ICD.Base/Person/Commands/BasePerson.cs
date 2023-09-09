using ICD.Framework.Model;

namespace ICD.Base
{
    public class BasePerson : Request<BasePersonResult>
    {
        public string NationalIdentity { get; set; }
        public string EconomicId { get; set; }
        public int PersonTitleRef { get; set; }

        public string _Name { get; set; }
        public string _LastName { get; set; }
        public string _FatherName { get; set; }
        
    }
    public class BasePersonResult: SingleQueryResult<BasePersonModel> { }
    public class BasePersonModel 
    {
        
    }
}
