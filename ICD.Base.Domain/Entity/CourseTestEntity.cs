using ICD.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Domain.Entity
{
    public class CourseTestEntity : BaseEntity<int>
    {
        public string Title { get; set; }
        public int Grade { get; set; }

        #region Navigation properties
        public int PersonTestRef { get; set; }
        public PersonTestEntity PersonTest { get; set; }
        #endregion
    }
}
