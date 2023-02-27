using Employee.DataModel.Models;

namespace EmployeeDetails.Api.IService
{
    public interface IInterviewService
    {
        Task<int> PostInterview(Interviews interview);
        Task<List<Interviews>> GetInterviewDetails();
    }
}
