using Employee.DataModel.Models;

namespace EmployeeDetails.Api.IService
{
    public interface IPOCService
    {
        Task<int> PostPOC(ProofOfConcept poc);
        Task<List<ProofOfConcept>> GetPOCDetails();
    }
}
