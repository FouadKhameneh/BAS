using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using ICD.Framework.Linq;
using ICD.Framework.Model;
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
    [Dependency(typeof(ICostTypeService))]
    public class CostTypeService : ICostTypeService
    {
        private readonly IUnitOfWork _db;
        private readonly ICostTypeRepository _costTypeRepository;
        private readonly ICostTypeLanguageRepository _costTypeLanguageRepository;
        private readonly IEntityService _entityService;

        public CostTypeService(IUnitOfWork db, IEntityService entityService)
        {
            _db = db;
            _costTypeRepository = _db.GetRepository<ICostTypeRepository>();
            _costTypeLanguageRepository = _db.GetRepository<ICostTypeLanguageRepository>();
            _entityService = entityService;
        }

        public async Task<DeleteTypeShortResult> DeleteCostTypeByIdAsync(DeleteTypeShortRequest request)
        {
            await _costTypeRepository.DeleteWithAsync(c => c.Key == request.Key);
            await _costTypeLanguageRepository.DeleteWithAsync(cl => cl.CostTypeRef == request.Key);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                SqlErrorHandling.Handler(e);
            }

            return new DeleteTypeShortResult { Success = true };
        }

        public async Task<GetCostTypeResult> GetCostTypeAsync(GetCostTypeQuery query)
        {
            var result = new GetCostTypeResult
            {
                Entities = new List<GetCostTypeModel>(),
                PageIndex = query.Page,
                PageSize = query.Take
            };

            var searchQuery = query.ToQueryDataSource<CostTypeView>();

            searchQuery.AddFilter(new ExpressionFilterInfo<CostTypeView>(x => x.CompanyRef == query.CompanyRef));
            searchQuery.DisablePaging = true;

            var costTypeResult = await _costTypeRepository.GetCostTypeAsync(searchQuery, query.LanguageRef);

            if (!costTypeResult.Entities.Any())
                return result;

            foreach (var item in costTypeResult.Entities)
            {
                if (result.Entities.Where(x => x.Key == item.Key).Any())
                    continue;

                var newRes = item.MapTo<GetCostTypeModel>();

                var costTypes = costTypeResult.Entities.Where(x => x.Key == item.Key);

                if (costTypes.IsNotNull() && costTypes.Any() && item.TaxPercent.IsNotNull())
                    newRes.SumTaxPercent = costTypes.Sum(x => (decimal)x.TaxPercent);

                result.Entities.Add(newRes);
            }

            result.TotalCount = result.Entities.Count;
            result.Entities = result.Entities.SortAndPage(query).ToList();
            return result;
        }

        public async Task<GetCostTypeByKeyResult> GetCostTypeByKeyAsync(GetCostTypeByKeyQuery query)
        {
            var finalResult = new GetCostTypeByKeyResult();

            var queryDataSource = query.ToQueryDataSource<CostTypeView>();

            queryDataSource.AddFilter(new ExpressionFilterInfo<CostTypeView>(x => x.Key == query.Key));
            queryDataSource.DisablePaging = true;

            var costTypeResult = await _costTypeRepository.GetCostTypeAsync(queryDataSource, query.LanguageRef);

            if (!costTypeResult.Entities.Any())
                return finalResult;

            var sumTaxPercent = costTypeResult.Entities.Sum(x => x.TaxPercent);
            var res = costTypeResult.Entities.First();
            finalResult.Entity = res.MapTo<GetCostTypeModel>();
            finalResult.Entity.SumTaxPercent = sumTaxPercent;

            return finalResult;
        }

        public async Task<BaseCostTypeResult> InsertCostTypeAsync(InsertCostTypeRequest request)
        {
            var costTypeEntity = request.MapTo<CostTypeEntity>();

            costTypeEntity.CostTypeLanguages = new List<CostTypeLanguageEntity>
            {
                new CostTypeLanguageEntity
                {
                    LanguageRef = request.LanguageRef,
                    _Title = request._Title,
                    _Description = request._Description
                }
            };

            await _costTypeRepository.AddAsync(costTypeEntity);

            try
            {
                await _db.SaveChangesAsync();

                await _entityService.InsertMultilingualEntityAsync<CostTypeEntity, InsertCostTypeRequest, short>(costTypeEntity, request);
            }
            catch (DbUpdateException e)
            {
                SqlErrorHandling.Handler(e, "DuplicateValue");
            }

            return new BaseCostTypeResult();
        }

        public async Task<BaseCostTypeResult> UpdateCostTypeAsync(UpdateCostTypeRequest request)
        {
            var costTypeEntity = await _costTypeRepository.FindAsync(request.Key);

            if (costTypeEntity.IsNull())
                throw new ICDException("NotFound");

            costTypeEntity = request.MapTo<CostTypeEntity>();
            costTypeEntity.Key = request.Key;

            _costTypeRepository.Update(costTypeEntity);

            var costTypeLanguageEntity = await _costTypeLanguageRepository.FirstOrDefaultAsync(cl => cl.CostTypeRef == request.Key && cl.LanguageRef == request.LanguageRef);
            
            if (costTypeLanguageEntity.IsNull())
                throw new ICDException("NotFound");

            var key = costTypeLanguageEntity.Key;
            costTypeLanguageEntity = request.MapTo<CostTypeLanguageEntity>();
            costTypeLanguageEntity.CostTypeRef = request.Key;
            costTypeLanguageEntity.Key = key;


            _costTypeLanguageRepository.Update(costTypeLanguageEntity);

            await _db.SaveChangesAsync();

            return new BaseCostTypeResult { Success = true };
        }
    }
}
