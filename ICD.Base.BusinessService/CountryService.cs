using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.AppSetting;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.QueryDataSource.Fitlter;
using ICD.Infrastructure.BusinessServiceContract;
using ICD.Infrastructure.Exception;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(ICountryService))]
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork _db;
        private readonly ICountryRepository _countryRepository;
        private readonly ICountryLanguageRepository _countryLanguageRepository;
        private readonly IEntityService _entityService;

        public CountryService(IUnitOfWork db, IEntityService entityService)
        {
            _db = db;
            _countryRepository = _db.GetRepository<ICountryRepository>();
            _countryLanguageRepository = _db.GetRepository<ICountryLanguageRepository>();
            _entityService = entityService;
        }

        public async Task<DeleteTypeIntResult> DeleteCountryByIdAsync(DeleteTypeIntRequest request)
        {
            await _countryRepository.DeleteWithAsync(c => c.Key == request.Key);
            await _countryLanguageRepository.DeleteWithAsync(cl => cl.CountryRef == request.Key);

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

        public async Task<GetCountryResult> GetCountryAsync(GetCountryQuery query)
        {
            var result = new GetCountryResult
            {
                Entities = new List<GetCountryModel>()
            };

            var searchQuery = query.ToQueryDataSource<CountryView>();

            var countryResult = await _countryRepository.GetCountryAsync(searchQuery, query.LanguageRef);

            if (countryResult.Entities.Any())
            {
                result = countryResult.MapTo<GetCountryResult>();
            }

            return result;
        }

        public async Task<GetCountryByKeyResult> GetCountryByKeyAsync(GetCountrybyKeyQuery query)
        {
            var result = new GetCountryByKeyResult
            {
                Entity = new GetCountryByKeyModel()
            };

            var searchQuery = query.ToQueryDataSource<CountryView>();

            searchQuery.AddFilter(new ExpressionFilterInfo<CountryView>(x => x.Key == query.Key));

            var countryResult = await _countryRepository.GetCountryAsync(searchQuery, query.LanguageRef);

            if (countryResult.Entities.Any())
            {
                result.Entity = countryResult.Entities.FirstOrDefault().MapTo<GetCountryByKeyModel>();
            }

            return result;
        }

        public async Task<BaseCountryResult> InsertCountryAsync(InsertCountryRequest request)
        {
            var countryEntity = request.MapTo<CountryEntity>();

            countryEntity.CountryLanguages = new List<CountryLanguageEntity>
            {
                new CountryLanguageEntity
                {
                    LanguageRef = request.LanguageRef,
                    _Title = request._Title
                }
            };

            await _countryRepository.AddAsync(countryEntity);

            //var countryLanguageEntity = request.MapTo<CountryLanguageEntity>();
            //countryLanguageEntity.CountryRef = countryEntity.Key;
            //await _countryLanguageRepository.AddAsync(countryLanguageEntity);

            try
            {
                await _db.SaveChangesAsync();

                await _entityService.InsertMultilingualEntityAsync<CountryEntity, InsertCountryRequest, int>(countryEntity, request);
            }
            catch (DbUpdateException e)
            {
                SqlErrorHandling.Handler(e, "DuplicateValue");
            }
            return new BaseCountryResult();
        }

        public async Task<BaseCountryResult> UpdateCountryAsync(UpdateCountryRequest request)
        {
            var countryEntity = await _countryRepository.FindAsync(request.Key);

            if (countryEntity.IsNull())
                throw new ICDException("NotFound");


            countryEntity = request.MapTo<CountryEntity>();
            countryEntity.Key = request.Key;


            var countryLanguageEntity = await _countryLanguageRepository.FirstOrDefaultAsync(cl => cl.CountryRef == request.Key && cl.LanguageRef == request.LanguageRef);

            if (countryLanguageEntity.IsNull())
                throw new ICDException("NotFound");

            var key = countryLanguageEntity.Key;
            countryLanguageEntity = request.MapTo<CountryLanguageEntity>();
            countryLanguageEntity.CountryRef = request.Key;
            countryLanguageEntity.Key = key;


            _countryRepository.Update(countryEntity);
            _countryLanguageRepository.Update(countryLanguageEntity);


            await _db.SaveChangesAsync();

            return new BaseCountryResult { Success = true };
        }
    }
}
