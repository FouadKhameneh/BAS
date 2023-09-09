using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract
{
    public interface ILocationService
    {
        Task<BaseLocationResult> InsertLocationAsync(InsertLocationRequest request);
        Task<GetLocationResult> GetLocationAsync(GetLocationQuery query);
        Task<BaseLocationResult> UpdateLocationAsync(UpdateLocationRequest request);
        Task<DeleteTypeIntResult> DeleteLocationByIdAsync(DeleteTypeIntRequest request);
    }
}
