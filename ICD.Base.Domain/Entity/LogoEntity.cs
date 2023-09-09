using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class LogoEntity : BaseEntity<int>
    {
        public string LogoData { get; set; }
        public string Alias { get; set; }
    }
}
