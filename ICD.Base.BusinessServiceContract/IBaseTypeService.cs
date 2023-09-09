using ICD.Framework.Model;
using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IBaseTypeService
    {
        Task<BaseTypeResult> InsertBaseTypeAsync(InsertBaseTypeRequest request);
        Task<BaseTypeResult> DeletePersonBaseTypeAsync(DeleteBaseTypeRequest request);
        Task<GetBaseTypeKeyByAliasResult> GetBaseTypeKeyByAliasAsync(GetBaseTypeKeyByAliasQuery query);
        Task<BasePersonBaseTypeResult> InsertPersonBaseTypeAsync(InsertPersonBaseTypeRequest request);
    }
}
