using ICD.Base.BusinessServiceContract;
using ICD.Framework.DataAnnotation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(ICourseTestService))]
    public class CourseTestService : ICourseTestService
    {
    }
}
