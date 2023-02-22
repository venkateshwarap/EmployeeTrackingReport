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

        public class LoginModel
        {
            public string UserName { get; set; }
            public string security { get; set; }
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var employee = (Employees)_context.Employees.ToList().Find(x => x.Email == loginModel.UserName);
           
            if(employee == null)
            {
                return BadRequest("User not found.");
            }
            else
            {
                var userDetails = _context.UserDetails.ToList().Find(u => u.EmpId == employee.Id);
                if (userDetails.Key == loginModel.security)
                {
                    return Ok();
                }

            }
            return Ok("User successfully");
        }

    }
}
