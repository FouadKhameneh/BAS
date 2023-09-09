using ICD.Base.BusinessServiceContract;
using ICD.Base.Domain.Entity;
using ICD.Base.Domain.View;
using ICD.Base.RepositoryContract;
using ICD.Framework.AppMapper.Extensions;
using ICD.Framework.Data.UnitOfWork;
using ICD.Framework.DataAnnotation;
using ICD.Framework.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessService
{
    [Dependency(typeof(ICostTypeTaxService))]
    public class CostTypeTaxService : ICostTypeTaxService
    {
        private readonly IUnitOfWork _db;
        private readonly ICostTypeTaxRepository _costTypeTaxRepository;

        public CostTypeTaxService(IUnitOfWork db)
        {
            _db = db;
            _costTypeTaxRepository = _db.GetRepository<ICostTypeTaxRepository>();
        }

        public async Task<GetCostTypeTaxResult> GetCostTypeTaxAsync(GetCostTypeTaxQuery query)
        {
            var result = new GetCostTypeTaxResult
            {
                Entities = new List<GetCostTypeTaxModel>()
            };

            var searchQuery = query.ToQueryDataSource<CostTypeTaxView>();

            var costTypeTaxResult = await _costTypeTaxRepository.GetCostTypeTaxAsync(searchQuery, query.LanguageRef, query.CostTypeRef);

            return costTypeTaxResult.MapTo<GetCostTypeTaxResult>();
        }

        public async Task<BaseCostTypeTaxResult> InsertCostTypeTaxAsync(InsertCostTypeTaxRequest request)
        {
            if (request.TaxRefs.Count == 0)
            {
                await _costTypeTaxRepository.DeleteWithAsync(x => x.CostTypeRef == request.CostTypeRef);

                await _db.SaveChangesAsync();

                return new BaseCostTypeTaxResult();
            }


            await _costTypeTaxRepository.DeleteWithAsync(x => x.CostTypeRef == request.CostTypeRef);


            foreach (var tax in request.TaxRefs)
            {
                var costTypeTaxEntity = new CostTypeTaxEntity()
                {
                    CostTypeRef = request.CostTypeRef,
                    TaxRef = tax
                };

                await _costTypeTaxRepository.AddAsync(costTypeTaxEntity);
            }

            await _db.SaveChangesAsync();

            return new BaseCostTypeTaxResult();
        }
    }
}
