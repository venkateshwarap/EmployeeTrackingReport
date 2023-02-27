using Employee.DataModel.Models;

namespace EmployeeTrackingApp.Service
{
    public class InterviewService
    {
        private readonly HttpClient _httpClient;
        public InterviewService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Interviews>> GetInterviewDetails()
        {
            var interview = await _httpClient.GetFromJsonAsync<Interviews[]>(AppSettings.GetInterview);
            return interview;
        }
    }
}
