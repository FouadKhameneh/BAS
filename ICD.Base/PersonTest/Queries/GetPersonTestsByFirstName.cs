using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetPersonTestsByFirstNameQuery : Query
    {
        public string FirstName { get; set; }
    }
    public class GetPersonTestsByFirstNameResult : ListQueryResult<GetPersonTestsByFirstNameModel> { }
    public class GetPersonTestsByFirstNameModel
    {
        public int Key { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
