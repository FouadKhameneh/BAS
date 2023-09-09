using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.View
{
    public class SanaSupportInfoView
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
