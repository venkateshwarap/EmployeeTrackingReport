using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetails.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private IInterviewService _interviewService;
        public InterviewController(IInterviewService interviewService)
        {
            this._interviewService = interviewService;
        }
        [HttpGet("GetInterview")]
        public async Task<IActionResult> GetInterview()
        {
            try
            {
                var i = await _interviewService.GetInterviewDetails();
                if (i == null)
                {
                    return NotFound();
                }
                return Ok(i);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost("AddInterview")]
        public async Task<IActionResult> AddInterview([FromBody] Interviews interview)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var i = await _interviewService.PostInterview(interview);
                    if (i > 0)
                    {
                        return Ok(i);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest();
                }
            }

            return BadRequest();
        }
    }
}
