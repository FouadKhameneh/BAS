using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class SanaSupportInfoEntity : BaseEntity<int>
    {
        public string PhoneNo { get; set; }
        public string WhatsAppID { get; set; }
        public DateTime CreateDate { get; set; }
        public string MobileNo { get; set; }

        #region Navigation Property
        public long PersonRef { get; set; }
        public PersonEntity Person { get; set; }
        #endregion
    }
}
