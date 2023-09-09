using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
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
    [Dependency(typeof(ICityRepository))]
    public class CityRepository : BaseRepository<CityEntity, int>, ICityRepository
    {
        public async Task<ListQueryResult<CityView>> GetCityAsync(QueryDataSource<CityView> searchQuery, int languageRef)
        {
            var result = new ListQueryResult<CityView>
            {
                Entities = new List<CityView>()
            };

            var queryResult = from c in GenericRepository.Query<CityEntity>()
                              join cl in GenericRepository.Query<CityLanguageEntity>()
                              on c.Key equals cl.CityRef
                              where cl.LanguageRef == languageRef
                              select new CityView
                              {
                                  Key = c.Key,
                                  CountryRef = c.CountryRef,
                                  IsActive = c.IsActive, 
                                  _Title = cl._Title,
                                  _Description = cl._Description
                              };

            result = await queryResult.ToListQueryResultAsync(searchQuery);

            return result;
        }
    }
}
