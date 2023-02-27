using EmployeeDetails.Api.IService;
using EmployeeDetails.Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetails.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            this._dashboardService = dashboardService;
        }
        [HttpGet("GetEmployeeDetails")]
        public async Task<IActionResult> GetEmployee()
        {
            try
            {
                var e = await _dashboardService.GetEmployeeDetails();
                if (e == null)
                {
                    return NotFound();
                }
                return Ok(e);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
