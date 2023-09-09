using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetPersonTitleByKeyQuery : Query
    {
        public int Key { get; set; }
    }
    public class GetPersonTitleByKeyResult : SingleQueryResult<GetPersonTitlesModel> { }
}
