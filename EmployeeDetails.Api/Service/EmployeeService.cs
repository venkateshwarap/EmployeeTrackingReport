using Employee.DataModel.CustomModel;
using Employee.DataModel.Models;
using EmployeeDetails.Api.IService;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace EmployeeDetails.Api.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly BlazorDataTestContext _dataTestContext;
        public EmployeeService(BlazorDataTestContext dataTestContext)
        {
            _dataTestContext = dataTestContext;
        }

        public ResponseModel AddEmployee(EmployeeModel employeeModel)
        {
            var response = _dataTestContext.Add(employeeModel);
            _dataTestContext.SaveChanges();
            return new ResponseModel()
            {
                Message = "Inserted Seccessfully",
                Status = true
            };
        }

        public List<EmployeeModel> GetAll()
        {
            return _dataTestContext.EmployeeModels.ToList();
        }
    }
}
