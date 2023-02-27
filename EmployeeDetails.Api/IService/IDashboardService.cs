using Employee.DataModel.Models;

namespace EmployeeDetails.Api.IService
{
    public interface IDashboardService
    {
        Task<List<Employees>> GetEmployeeDetails();
    }
}
