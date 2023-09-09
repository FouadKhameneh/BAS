using ICD.Framework.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base
{
    public class BaseSanaSupportInfo : Request<BaseSanaSupportInfoResult>
    {
        public long PersonRef { get; set; }
        public string PhoneNo { get; set; }
        public string WhatsAppID { get; set; }
        public DateTime CreateDate { get; set; }
        public string MobileNo { get; set; }
    }
    public class BaseSanaSupportInfoResult : SingleQueryResult<BaseSanaSupportInfoModel> { }
    public class BaseSanaSupportInfoModel { }
}
