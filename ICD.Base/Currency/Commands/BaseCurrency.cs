using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseCurrency : Request<BaseCurrencyResult>
    {
        public bool IsActive { get; set; }
        public bool IsNational { get; set; }
        public string Icon { get; set; }

        public string _Title { get; set; }
    }
    public class BaseCurrencyResult : SingleQueryResult<BaseCurrencyModel> { }
    public class BaseCurrencyModel { }
}
