using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ICostTypeTaxService
    {
        Task<BaseCostTypeTaxResult> InsertCostTypeTaxAsync(InsertCostTypeTaxRequest request);
        Task<GetCostTypeTaxResult> GetCostTypeTaxAsync(GetCostTypeTaxQuery query);
    }
}
