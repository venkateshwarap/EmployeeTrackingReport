using Employee.DataModel.Models;
using EmployeeTrackingApp.Service;
using Microsoft.AspNetCore.Components;

namespace EmployeeTrackingApp.Pages
{
    public partial class Interview
    {
        public IEnumerable<Interviews> interviews { get; set; }
        [Inject]
        public InterviewService service { get; set; }

        protected override async Task OnInitializedAsync()
        {
            interviews = (await service.GetInterviewDetails()).ToList();
        }
    }
}
