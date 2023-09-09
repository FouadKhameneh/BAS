using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICD.Base.Domain.Entity
{
    public class GLNLanguageEntity : BaseEntity<long>
    {
        public int LanguageRef { get; set; }
        public string _Title { get; set; }
        public string _Address { get; set; }

        #region Navigation Props
        public long GLNRef { get; set; }
        public GLNEntity GLNE { get; set; }
        #endregion
    }
}
