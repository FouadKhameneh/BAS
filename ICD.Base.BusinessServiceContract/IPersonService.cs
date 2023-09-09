using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IPersonService
    {
        Task<InsertPersonResult> InsertPersonAsync(InsertPersonRequest request);
        Task<GetPeopleByspecificationResult> GetBySpecificationAsync(GetPeopleBySpecificationQuery query);
        Task<DeleteTypeLongResult> DeleteByIdAsync(DeleteTypeLongRequest request);
        Task<BasePersonResult> UpdatePersonAsync(UpdatePersonRequest request);
        Task<GetPeopleByKeyResult> GetPeopleByKeyAsync(GetPeopleByKeyQuery query);
    }
}
