using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class InsertTaxByTableNameRequest : Request<InsertTaxByTableNameResult>
    {
        public string TableName { get; set; }

        public decimal TaxPercent { get; set; }
        public string Alias { get; set; }
        public bool IsActive { get; set; }

        public string _Title { get; set; }
        public string _Description { get; set; }
    }

    public class InsertTaxByTableNameResult : SingleQueryResult<InsertTaxByTableNameModel> { }
    public class InsertTaxByTableNameModel
    {
        public long ApplicationRef { get; set; }
        public long TableRef { get; set; }
        public int EntityRef { get; set; }
    }
}
