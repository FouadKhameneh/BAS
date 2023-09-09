using ICD.Base.Domain.External_Entity.INF;
using ICD.Base.Domain.External_View;
using ICD.Base.RepositoryContract.External_Repository_Contract.INF;
using ICD.Framework.Data.Repository;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Model;
using ICD.Framework.QueryDataSource;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ICD.Framework.Extensions;

namespace ICD.Base.Repository.External_Repository.INF
{
    [Dependency(typeof(IApplicationRepository))]
    public class ApplicationRepository : BaseRepository<ApplicationEntity, long>, IApplicationRepository
    {
        public async Task<ListQueryResult<ApplicationKeyView>> GetApplicationKeyAsync(QueryDataSource<ApplicationKeyView> searchQuery)
        {
            var finalResult = new ListQueryResult<ApplicationKeyView>
            {
                Entities = new List<ApplicationKeyView>()
            };

            var queryResult = from a in GenericRepository.Query<ApplicationEntity>()
                              join at in GenericRepository.Query<ApplicationTableEntity>()

                              on a.Key equals at.ApplicationRef

                              select new ApplicationKeyView
                              {
                                  ApplicationKey = a.Key,
                                  ApplicationTableKey = at.Key, 
                                  Alias = a.Alias,
                                  Name = at.Name
                              };

            var result = await queryResult.ToListQueryResultAsync(searchQuery);

            finalResult = result;

            return finalResult;
        }
    }
}
