using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ICountryService
    {
        Task<BaseCountryResult> InsertCountryAsync(InsertCountryRequest request);
        Task<GetCountryResult> GetCountryAsync(GetCountryQuery query);
        Task<GetCountryByKeyResult> GetCountryByKeyAsync(GetCountrybyKeyQuery query);
        Task<BaseCountryResult> UpdateCountryAsync(UpdateCountryRequest request);
        Task<DeleteTypeIntResult> DeleteCountryByIdAsync(DeleteTypeIntRequest request);
    }
}
