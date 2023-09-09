using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseExpenseCenter : Request<BaseExpenseCenterResult>
    {
        public bool IsActive { get; set; }
        public short CompanyRef { get; set; }
        public string _Title { get; set; }
    }
    public class BaseExpenseCenterResult : SingleQueryResult<BaseExpenseCenterModel> { }
    public class BaseExpenseCenterModel { }
}
