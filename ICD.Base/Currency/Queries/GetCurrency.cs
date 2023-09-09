using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetCurrencyQuery : Query
    {
    }
    public class GetCurrencyResult : ListQueryResult<GetCurrencyModel> { }
    public class GetCurrencyModel
    {
        public byte Key { get; set; }
        public bool IsActive { get; set; }
        public bool IsNational { get; set; }
        public string Icon { get; set; }

        public byte CurrencyRef { get; set; }
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
    }
}
