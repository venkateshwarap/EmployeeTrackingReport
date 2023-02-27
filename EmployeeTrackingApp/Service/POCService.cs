using Employee.DataModel.Models;

namespace EmployeeTrackingApp.Service
{
    public class POCService
    {
        private readonly HttpClient _httpClient;

        public POCService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<ProofOfConcept>> GetPOCDetails()
        {
            var poc = await _httpClient.GetFromJsonAsync<ProofOfConcept[]>(AppSettings.GetPOC);
            return poc;
        }
    }
}
