using System.Threading.Tasks;

namespace ICD.Base.BusinessServiceContract;

public interface ITeacherTestService
{
    Task<BaseTeacherTestResult> InsertTeacherTestAsync(InsertTeacherTestRequest request);
    
    Task<BaseTeacherTestResult> UpdateTeacherTestAsync(UpdateTeacherTestRequest request);
    
    Task<DeleteTypeIntResult> DeleteTeacherTestAsync(DeleteTypeIntRequest request);
    
    Task<GetAllTeacherTestsResult> GetAllTeacherTestsAsync(GetAllTeacherTestsQuery query);
}