using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class CountryLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }

        #region Navigation Prop
        public int CountryRef { get; set; }
        public CountryEntity Country { get; set; }
        #endregion
    }
}
