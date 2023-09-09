using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetCurrencyByKeyQuery : Query
    {
        public short Key { get; set; }
    }
    public class GetCurrencyByKeyResult : SingleQueryResult<GetCurrencyModel> { }
}
