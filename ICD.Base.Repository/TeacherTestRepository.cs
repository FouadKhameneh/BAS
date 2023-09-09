using ICD.Base.Domain.Entity;
using ICD.Base.RepositoryContract;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.Repository
{
    [Dependency(typeof(ITeacherTestRepository))]
    public class TeacherTestRepository : BaseRepository<TeacherTestEntity, int>, ITeacherTestRepository
    {
        public async Task<ListQueryResult<TeacherTestEntity>> GetAllTeacherTestsAsync(QueryDataSource<TeacherTestEntity> queryDataSource)
        {
            var result = new ListQueryResult<TeacherTestEntity>
            {
                Entities = new List<TeacherTestEntity>()
            };

            var queryResult = from tt in GenericRepository.Query<TeacherTestEntity>()
                select tt;

            result = await queryResult.ToListQueryResultAsync(queryDataSource);

            return result;
        }
    }
}