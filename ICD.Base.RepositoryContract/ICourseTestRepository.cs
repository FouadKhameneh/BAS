using ICD.Base.Domain.Entity;
using ICD.Framework.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.RepositoryContract
{
    public interface ICourseTestRepository : IRepository<CourseTestEntity,int>
    {
    }
}
