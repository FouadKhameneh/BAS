using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Domain.Entity
{
    public class PersonTestEntity : BaseEntity<int>
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }

        #region Navigation Properties
        public ICollection<CourseTestEntity> CourseTests { get; set; }
        #endregion
    }
}
