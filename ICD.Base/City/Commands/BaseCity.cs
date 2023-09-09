using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class BaseCity : Request<BaseCityResult>
    {
        public int CountryRef { get; set; }
        public bool IsActive { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }
    }
    public class BaseCityResult : SingleQueryResult<BaseCityModel>
    {
    }

    public class BaseCityModel
    {
    }
}
