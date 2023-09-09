using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetCityQuery : Query
    {
        public bool? IsActive { get; set; }
    }

    public class GetCityResult : ListQueryResult<GetCityModel> { }

    public class GetCityModel
    {
        public byte Key { get; set; }
        public bool IsActive { get; set; }
        public int CountryRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }
    }
}
