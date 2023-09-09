using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class CostTypeTaxEntity : BaseEntity<int>
    {
        #region Navigation Props
        public short CostTypeRef { get; set; }
        public CostTypeEntity CostType { get; set; }

        public int TaxRef { get; set; }
        public TaxEntity Tax { get; set; }
        #endregion
    }
}
