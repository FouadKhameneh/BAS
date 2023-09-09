using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.QueryDataSource.Fitlter;
using ICD.Infrastructure.BusinessServiceContract;
using ICD.Infrastructure.Exception;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(ICityService))]
    public class CityService : ICityService
    {
        private readonly IUnitOfWork _db;
        private readonly ICityRepository _cityRepository;
        private readonly ICityLanguageRepository _cityLanguageRepository;
        private readonly IEntityService _entityService;

        public CityService(IUnitOfWork db, IEntityService entityService)
        {
            _db = db;
            _cityRepository = _db.GetRepository<ICityRepository>();
            _cityLanguageRepository = _db.GetRepository<ICityLanguageRepository>();
            _entityService = entityService;
        }

        public async Task<BaseCityResult> InsertCityAsync(InsertCityRequest request)
        {
            var cityEntity = request.MapTo<CityEntity>();

            cityEntity.CityLanguages = new List<CityLanguageEntity>()
            {
                new CityLanguageEntity
                {
                    LanguageRef = request.LanguageRef,
                    _Title = request._Title,
                    _Description = request._Description
                }
            };

            await _cityRepository.AddAsync(cityEntity);

            try
            {
                await _db.SaveChangesAsync();

                await _entityService.InsertMultilingualEntityAsync<CityEntity, InsertCityRequest, int>(cityEntity, request);
            }
            catch (DbUpdateException e)
            {
                SqlErrorHandling.Handler(e, "DuplicateValue");
            }


            return new BaseCityResult { Success = true };


        }

        public async Task<BaseCityResult> UpdateCityAsync(UpdateCityRequest request)
        {
            var cityEntity = await _cityRepository.FirstOrDefaultAsync(x => x.Key == request.Key);

            if (cityEntity.IsNull())
                throw new ICDException("NotFound");

            cityEntity = request.MapTo<CityEntity>();
            cityEntity.Key = request.Key;

            var cityLanguageEntity = await _cityLanguageRepository.FirstOrDefaultAsync(cl => cl.CityRef == request.Key && cl.LanguageRef == request.LanguageRef);

            if (cityLanguageEntity.IsNull())
                throw new ICDException("NotFound");

            ///////
            var key = cityLanguageEntity.Key;
            cityLanguageEntity = request.MapTo<CityLanguageEntity>();
            cityLanguageEntity.CityRef = request.Key;
            cityLanguageEntity.Key = key;


            _cityRepository.Update(cityEntity);
            _cityLanguageRepository.Update(cityLanguageEntity);


            await _db.SaveChangesAsync();

            return new BaseCityResult { Success = true };


        }

        public async Task<DeleteTypeIntResult> DeleteCityAsync(DeleteTypeIntRequest request)
        {
            await _cityRepository.DeleteWithAsync(c => c.Key == request.Key);
            await _cityLanguageRepository.DeleteWithAsync(cl => cl.CityRef == request.Key);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                SqlErrorHandling.Handler(e);
            }

            return new DeleteTypeIntResult { Success = true };

        }

        public async Task<GetCityResult> GetCityAsync(GetCityQuery query)
        {
            var result = new GetCityResult
            {
                Entities = new List<GetCityModel>()
            };

            var searchQuery = query.ToQueryDataSource<CityView>();

            if (query.IsActive.HasValue)
                searchQuery.AddFilter(new ExpressionFilterInfo<CityView>(x => x.IsActive == query.IsActive.Value));

            var cityResult = await _cityRepository.GetCityAsync(searchQuery, query.LanguageRef);

            if (cityResult.Entities.Any())
            {
                result = cityResult.MapTo<GetCityResult>();
            }

            return result;
        }

    }
}
