using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class CurrencyLanguageEntity : BaseEntity<byte>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Prop
        public byte CurrencyRef { get; set; }
        public CurrencyEntity Currency { get; set; }
        #endregion
    }
}
