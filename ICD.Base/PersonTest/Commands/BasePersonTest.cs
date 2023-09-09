using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base
{
    public class BasePersonTest : Request<BasePersonTestResult>
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
    }

    public class BasePersonTestResult : SingleQueryResult<BasePersonTestModel> { }

    public class BasePersonTestModel 
    {
    }
}
