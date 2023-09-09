using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IPersonTitleService
    {
        Task<BasePersonTitleResult> InsertPersonTitleAsync(InsertPersonTitleRequest request);
        Task<GetPersonTitlesResult> GetPersonTitlesByLanguageRefAsync(GetPersonTitlesQuery query);
        Task<DeleteTypeIntResult> DeletePersonTitleByIdAsync(DeleteTypeIntRequest request);
        Task<BasePersonTitleResult> UpdatePersonTitleByIdAsync(UpdatePersonTitleRequest request);
        Task<GetPersonTitleByKeyResult> GetPersonTitleByKeyAsync(GetPersonTitleByKeyQuery query);
        //object TestGetPersonProc();
    }
}
