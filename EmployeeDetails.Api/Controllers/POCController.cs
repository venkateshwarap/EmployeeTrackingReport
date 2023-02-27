using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POCController : ControllerBase
    {
        private IPOCService _pocService;
        public POCController(IPOCService pocService)
        {
            this._pocService = pocService;
        }
        [HttpGet("GetPOCDetails")]
        public async Task<IActionResult> GetPOC()
        {
            try
            {
                var p = await _pocService.GetPOCDetails();
                if (p == null)
                {
                    return NotFound();
                }
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost("AddPOC")]
        public async Task<IActionResult> AddPOC([FromBody] ProofOfConcept poc)
        {
            if (ModelState.IsValid)
            {
                try
                {                   
                    var p = await _pocService.PostPOC(poc);
                    if (p > 0)
                    {
                        return Ok(p);
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
