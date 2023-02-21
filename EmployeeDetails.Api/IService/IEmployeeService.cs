using Employee.DataModel.CustomModel;
using Employee.DataModel.Models;
using System.Collections;

namespace EmployeeDetails.Api.IService
{
    public interface IEmployeeService
    {
        public ResponseModel AddEmployee(EmployeeModel employeeModel);
        List<EmployeeModel> GetAll();
    }
}
