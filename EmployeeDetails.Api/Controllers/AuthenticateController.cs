using Employee.DataModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly EtreportContext _context;
        public AuthenticateController(EtreportContext context)
        {
            _context= context;  
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                var employee = (Employees)_context.Employees.ToList().Find(x => x.Email == loginModel.UserName);

                if (employee!= null && _context.Employees.ToList().FindAll(x => x.ManagerId == employee.Id).Count > 0)
                {

                    if (employee == null)
                    {
                        return BadRequest("User not found.");
                    }
                    else
                    {
                        var userDetails = _context.UserDetails.ToList().Find(u => u.EmpId == employee.Id);
                        if (userDetails.Key == loginModel.security)
                        {
                            return Ok(userDetails);
                        }

                    }

                    return Ok("User successfully");
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
