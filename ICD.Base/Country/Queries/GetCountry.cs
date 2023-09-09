using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetCountryQuery : Query 
    {
    }
    public class GetCountryResult : ListQueryResult<GetCountryModel> { }
    public class GetCountryModel
    {
        public int Key { get; set; }
        public bool IsActive { get; set; }

        public int CountryRef { get; set; }
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
    }
}
