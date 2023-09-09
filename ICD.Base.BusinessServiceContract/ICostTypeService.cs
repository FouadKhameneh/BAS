using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ICostTypeService
    {
        Task<BaseCostTypeResult> InsertCostTypeAsync(InsertCostTypeRequest request);
        Task<GetCostTypeResult> GetCostTypeAsync(GetCostTypeQuery query);
        Task<BaseCostTypeResult> UpdateCostTypeAsync(UpdateCostTypeRequest request);
        Task<DeleteTypeShortResult> DeleteCostTypeByIdAsync(DeleteTypeShortRequest request);
        Task<GetCostTypeByKeyResult>  GetCostTypeByKeyAsync(GetCostTypeByKeyQuery query);
    }
}
