using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller;

[Route("api/Teacher-Tests")]
[ApiController]
public class TeacherTestController : BaseController
{
    private readonly ITeacherTestService _teacherTestService;
    
    public TeacherTestController(IAppSession appSession, ITeacherTestService teacherTestService) : base(appSession)
    {
        _teacherTestService = teacherTestService;
    }
    
    [HttpPost("insert")]
    public async Task<IActionResult> InsertTeacherTestAsync([FromBody] InsertTeacherTestRequest request)
    {
        var result = await _teacherTestService.InsertTeacherTestAsync(request);

        return Ok(result);
    }
    
    [HttpPost("update")]
    public async Task<IActionResult> UpdateTeacherTestAsync([FromBody] UpdateTeacherTestRequest request )
    {
        var result = await _teacherTestService.UpdateTeacherTestAsync(request);

        return Ok(result);
    }
    
    [HttpPost("delete")]
    public async Task<IActionResult> DeleteTeacherTestAsync([FromBody] DeleteTypeIntRequest request)
    {
        var result = await _teacherTestService.DeleteTeacherTestAsync(request);

        return Ok(result);
    }
    
    [HttpPost("get-all")]
    public async Task<IActionResult> GetAllTeacherTestsAsync([FromBody] GetAllTeacherTestsQuery query)
    {
        var result = await _teacherTestService.GetAllTeacherTestsAsync(query);

        return Ok(result);
    }
}