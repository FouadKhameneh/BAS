using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class GetExpenseCenterByKeyQuery : Query
    {
        public long Key { get; set; }
    }
    public class GetExpenseCenterByKeyResult : SingleQueryResult<GetExpenseCenterByKeyModel> { }

    public class GetExpenseCenterByKeyModel
    {
        public long Key { get; set; }
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }

        public int LanguageRef { get; set; }
        public string _Title { get; set; }
    }
}
