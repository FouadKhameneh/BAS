using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IContactTypeService
    {
        Task<BaseContactTypeResult> InsertContactTypeAsync(InsertContactTypeRequest request);
        Task<GetContactTypeResult> GetContactTypeAsync(GetContactTypeQuery query);
        Task<BaseContactTypeResult> UpdateContactTypeAsync(UpdateContactTypeRequest request);
        Task<DeleteTypeIntResult> DeleteContactTypeByIdAsync(DeleteTypeIntRequest request);
        Task<GetContactTypeByKeyResult> GetContactTypeByKeyAsync(GetContactTypeByKeyQuery query);
    }
}
