using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IPersonIdentityService
    {
        Task<BasePersonIdentityResult> InsertPersonIdentityAsync(InsertPersonIdentityRequest request);
        Task<GetPersonIdentityResult> GetPersonIdentityByPersonRefAsync(GetPersonIdentityQuery query);
        Task<DeleteTypeIntResult> DeletePersonIdentityByIdAsync(DeleteTypeIntRequest request);
        Task<BasePersonIdentityResult> UpdatePersonIdentityByIdAsync(UpdatePersonIdentityRequest request);
    }
}
