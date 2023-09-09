using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.External_Entity.INF
{
    public class ApplicationTableEntity : BaseEntity<long>
    {
        public string Name { get; set; }
        public bool IsBase { get; set; }
        public string Schema { get; set; }
        
        #region navigation Prop
        public long ApplicationRef { get; set; }
        public ApplicationEntity Application { get; set; }
        #endregion
    }
}
