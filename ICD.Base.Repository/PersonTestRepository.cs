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
    [Dependency(typeof(IPersonTestRepository))]
    public class PersonTestRepository : BaseRepository<PersonTestEntity, int>, IPersonTestRepository
    {
        public async Task<ListQueryResult<PersonTestEntity>> GetAllPersonTestsAsync(QueryDataSource<PersonTestEntity> queryDataSource)
        {
            var result = new ListQueryResult<PersonTestEntity>
            {
                Entities = new List<PersonTestEntity>()
            };

            var queryResult = from pt in GenericRepository.Query<PersonTestEntity>()
                              select pt;

            result = await queryResult.ToListQueryResultAsync(queryDataSource);

            return result;
        }
    }
}
