using Employee.DataModel.CustomModel;
using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetails.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpPost]
        [Route("SaveEmployee")]
        public IActionResult SaveEmployee(EmployeeModel employeeModel)
        {
           var data= _employeeService.AddEmployee(employeeModel);
            return Ok(data);            
        }
        [HttpGet]
        [Route("GetAllEmployee")]
        public IActionResult GetAllEmployee()
        {
            var data=_employeeService.GetEmployee();
            return Ok(data);
        }
    }
}
