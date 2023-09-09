using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ITaxService
    {
        Task<BaseTaxResult> InsertTaxAsync(InsertTaxRequest request);
        Task<InsertTaxByTableNameResult> InsertTaxByTableNameAsync(InsertTaxByTableNameRequest request);
        Task<GetTaxResult> GetTaxAsync(GetTaxQuery query);
        Task<BaseTaxResult> UpdateTaxAsync(UpdateTaxRequest request);
        Task<GetTaxByKeyResult> GetTaxByKeyAsync(GetTaxByKeyQuery query);
        Task<DeleteTypeIntResult> DeleteTaxByIdAsync(DeleteTypeIntRequest request);
    }
}
