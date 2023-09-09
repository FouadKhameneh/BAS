using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/Person-Tests")]
    [ApiController]
    public class PersonTestController : BaseController
    {
        private readonly IPersonTestService _personTestService;
        public PersonTestController(IAppSession appSession, IPersonTestService personTestService) : base(appSession)
        {
            _personTestService = personTestService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertPersonTestAsync([FromBody] InsertPersonTestRequest request)
        {
            var result = await _personTestService.InsertPersonTestAsync(request);

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePersonTestAsync([FromBody] UpdatePersonTestRequest request )
        {
            var result = await _personTestService.UpdatePersonTestAsync(request);

            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePersonTestAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _personTestService.DeletePersonTestAsync(request);

            return Ok(result);
        }

        [HttpPost("get-all")]
        public async Task<IActionResult> GetAllPersonTestsAsync([FromBody] GetAllPersonTestsQuery query)
        {
            var result = await _personTestService.GetAllPersonTestsAsync(query);

            return Ok(result);
        }

        [HttpPost("get-by-first-name")]
        public async Task<IActionResult> GetPersonTestsByFirstNameAsync([FromBody] GetPersonTestsByFirstNameQuery query)
        {
            var result = await  _personTestService.GetPersonTestsByFirstNameAsync(query);

            return Ok(result);
        }
    }
}
