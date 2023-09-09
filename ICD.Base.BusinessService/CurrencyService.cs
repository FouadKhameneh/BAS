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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(ICurrencyService))]
    public class CurrencyService : ICurrencyService
    {
        private readonly IUnitOfWork _db;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrencyLanguageRepository _currencyLanguageRepository;
        private readonly IEntityService _entityService;

        public CurrencyService(IUnitOfWork db, IEntityService entityService)
        {
            _db = db;
            _currencyRepository = _db.GetRepository<ICurrencyRepository>();
            _currencyLanguageRepository = _db.GetRepository<ICurrencyLanguageRepository>();
            _entityService = entityService;
        }

        public async Task<DeleteTypeByteResult> DeleteCurrencyByIdAsync(DeleteTypeByteRequest request)
        {
            await _currencyRepository.DeleteWithAsync(c => c.Key == request.Key);
            await _currencyLanguageRepository.DeleteWithAsync(cl => cl.CurrencyRef == request.Key);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                SqlErrorHandling.Handler(e);
            }

            return new DeleteTypeByteResult { Success = true };
        }

        public async Task<GetCurrencyResult> GetCurrencyAsync(GetCurrencyQuery query)
        {
            var result = new GetCurrencyResult
            {
                Entities = new List<GetCurrencyModel>()
            };

            var searchQuery = query.ToQueryDataSource<CurrencyView>();

            var currencyResult = await _currencyRepository.GetCurrencyAsync(searchQuery, query.LanguageRef);

            if (currencyResult.Entities.Any())
            {
                result = currencyResult.MapTo<GetCurrencyResult>();
            }

            return result;
        }

        public async Task<GetCurrencyByKeyResult> GetCurrencyByKeyAsync(GetCurrencyByKeyQuery query)
        {
            var finalResult = new GetCurrencyByKeyResult();

            var queryDataSource = query.ToQueryDataSource<CurrencyView>();
            queryDataSource.AddFilter(new ExpressionFilterInfo<CurrencyView>(x => x.Key == query.Key));

            var result = await _currencyRepository.GetCurrencyAsync(queryDataSource, query.LanguageRef);

            if (result.Entities.IsNull() || !result.Entities.Any())
                return finalResult;

            var res = result.Entities.First();

            finalResult.Entity = res.MapTo<GetCurrencyModel>();

            return finalResult;
        }

        public async Task<BaseCurrencyResult> InsertCurrencyAsync(InsertCurrencyRequest request)
        {
            var currencyEntity = request.MapTo<CurrencyEntity>();

            currencyEntity.CurrencyLanguages = new List<CurrencyLanguageEntity>
            {
                new CurrencyLanguageEntity
                {
                    LanguageRef = request.LanguageRef,
                    _Title = request._Title
                }
            };


            await _currencyRepository.AddAsync(currencyEntity);

            try
            {
                await _db.SaveChangesAsync();

                await _entityService.InsertMultilingualEntityAsync<CurrencyEntity, InsertCurrencyRequest, byte>(currencyEntity, request);
            }
            catch (DbUpdateException e)
            {
                SqlErrorHandling.Handler(e, "DuplicateValue");
            }
            return new BaseCurrencyResult();
        }

        public async Task<BaseCurrencyResult> UpdateCurrencyAsync(UpdateCurrencyRequest request)
        {
            var currencyEntity = await _currencyRepository.FindAsync(request.Key);

            if (currencyEntity.IsNull())
                throw new ICDException("NotFound");

            currencyEntity = request.MapTo<CurrencyEntity>();
            currencyEntity.Key = request.Key;


            var currencyLanguageEntity = await _currencyLanguageRepository.FirstOrDefaultAsync(cl => cl.CurrencyRef == request.Key && cl.LanguageRef == request.LanguageRef);
            if (currencyLanguageEntity.IsNull())
                throw new ICDException("NotFound");

            var key = currencyLanguageEntity.Key;
            currencyLanguageEntity = request.MapTo<CurrencyLanguageEntity>();
            currencyLanguageEntity.CurrencyRef = request.Key;
            currencyLanguageEntity.Key = key;


            _currencyRepository.Update(currencyEntity);
            _currencyLanguageRepository.Update(currencyLanguageEntity);

            await _db.SaveChangesAsync();

            return new BaseCurrencyResult { Success = true };
        }
    }
}
