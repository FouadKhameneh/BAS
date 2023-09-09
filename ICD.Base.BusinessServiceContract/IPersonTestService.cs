using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IPersonTestService
    {
        Task<BasePersonTestResult> InsertPersonTestAsync(InsertPersonTestRequest request);
        Task<BasePersonTestResult> UpdatePersonTestAsync(UpdatePersonTestRequest request);
        Task<DeleteTypeIntResult> DeletePersonTestAsync(DeleteTypeIntRequest request);
        Task<GetAllPersonTestsResult> GetAllPersonTestsAsync(GetAllPersonTestsQuery query);
        Task<GetPersonTestsByFirstNameResult> GetPersonTestsByFirstNameAsync(GetPersonTestsByFirstNameQuery query);
    }
}
