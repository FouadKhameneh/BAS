using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetCountrybyKeyQuery : Query
    {
        public int Key { get; set; }
    }
    public class GetCountryByKeyResult : SingleQueryResult<GetCountryByKeyModel> { }

    public class GetCountryByKeyModel
    {
        public int Key { get; set; }
        public bool IsActive { get; set; }

        public int CountryRef { get; set; }
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
    }
}
