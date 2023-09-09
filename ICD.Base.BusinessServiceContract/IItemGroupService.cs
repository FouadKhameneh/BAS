using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface IItemGroupService
    {
        Task<InsertItemGroupResult> InsertItemGroupAsync(InsertItemGroupRequest request);
        Task<GetItemGroupsResult> GetItemGroupsByApplicationRefAsync(GetItemGroupsQuery query);
        Task<GetItemGroupsByKeyResult> GetItemGroupsByKeyAsync(GetItemGroupsByKeyQuery query);
        Task<DeleteTypeIntResult> DeleteItemGroupByIdAsync(DeleteTypeIntRequest request);
        Task<BaseItemGroupResult> UpdateItemGroupByid(UpdateItemGroupRequest request);
    }
}
