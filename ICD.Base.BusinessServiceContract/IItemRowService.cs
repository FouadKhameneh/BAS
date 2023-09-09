using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IItemRowService
    {
        Task<InsertItemRowResult> InsertItemRowAsync(InsertItemRowRequest request);
        Task<GetItemRowsResult> GetItemRowsAsync(GetItemRowsQuery query);
        Task<DeleteItemRowResult> DeleteItemRowByIdAsync(DeleteItemRowRequest request);
    }
}
