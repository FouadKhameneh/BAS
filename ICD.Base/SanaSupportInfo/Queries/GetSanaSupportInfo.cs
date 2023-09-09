using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class GetSanaSupportInfoQuery : Query
    {

    }
    public class GetSanaSupportInfoResult : ListQueryResult<GetSanaSupportInfoModel> { }
    public class GetSanaSupportInfoModel
    {
        public int Key { get; set; }
        public long PersonRef { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string WhatsAppID { get; set; }
        public DateTime CreateDate { get; set; }
        public string MobileNo { get; set; }
    }
}
