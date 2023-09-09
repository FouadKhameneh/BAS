using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class CostTypeLanguageEntity : BaseEntity<short>
    {
        public string _Title { get; set; }
        public string _Description { get; set; }
        public int LanguageRef { get; set; }

        #region Navigation Props
        public short CostTypeRef { get; set; }
        public CostTypeEntity CostType { get; set; }
        #endregion
    }
}
