using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IExpenseCenterService
    {
        Task<BaseExpenseCenterResult> InsertExpenseCenterAsync(InsertExpenseCenterRequest request);
        Task<BaseExpenseCenterResult> UpdateExpenseCenterAsync(UpdateExpenseCenterRequest request);
        Task<DeleteTypeLongResult> DeleteExpenseCenterAsync(DeleteTypeLongRequest request);
        Task<GetExpenseCentersResult> GetExpenseCentersAsync(GetExpenseCentersQuery query);
        Task<GetExpenseCenterByKeyResult> GetExpenseCenterByKeyAsync(GetExpenseCenterByKeyQuery query);
    }
}
