using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseCountry : Request<BaseCountryResult>
    {
        public bool IsActive { get; set; }
        public string _Title { get; set; }
    }

    public class BaseCountryResult : SingleQueryResult<BaseCountryModel> { }
    public class BaseCountryModel { }
}
