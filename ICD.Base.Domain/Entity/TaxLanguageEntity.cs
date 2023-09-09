using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class TaxLanguageEntity : BaseEntity<int>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Description { get; set; }

        #region Navigation Prop
        public int TaxRef { get; set; }
        public TaxEntity Tax { get; set; }
        #endregion
    }
}
