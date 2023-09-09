using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetLogoQuery : Query
    {
        public string Alias { get; set; }
    }

    public class GetLogoResult : SingleQueryResult<GetLogoModel> { }

    public class GetLogoModel
    {
        public int Key { get; set; }
        public string LogoData { get; set; }
        public string Alias { get; set; }
    }
}
