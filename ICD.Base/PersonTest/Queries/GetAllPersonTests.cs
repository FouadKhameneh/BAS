using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetAllPersonTestsQuery : Query
    {
    }
    public class GetAllPersonTestsResult : ListQueryResult<GetAllPersonTestsModel> { }
    public class GetAllPersonTestsModel
    {
        public int Key { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int Age { get; set; }
    }
}
