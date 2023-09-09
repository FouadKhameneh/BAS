using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ICurrencyService
    {
        Task<BaseCurrencyResult> InsertCurrencyAsync(InsertCurrencyRequest request);
        Task<GetCurrencyResult> GetCurrencyAsync(GetCurrencyQuery query);
        Task<BaseCurrencyResult> UpdateCurrencyAsync(UpdateCurrencyRequest request);
        Task<DeleteTypeByteResult> DeleteCurrencyByIdAsync(DeleteTypeByteRequest request);
        Task<GetCurrencyByKeyResult> GetCurrencyByKeyAsync(GetCurrencyByKeyQuery query);
    }
}
