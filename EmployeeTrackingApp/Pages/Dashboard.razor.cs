using Employee.DataModel.Models;
using Microsoft.AspNetCore.Components;
using DashboardService = EmployeeTrackingApp.Service.DashboardService;

namespace EmployeeTrackingApp.Pages
{
    public partial class Dashboard
    {
        [Inject]
        public DashboardService service { get; set; }
        public IEnumerable<Employees> employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            employees = (await service.GetEmployeeDetails()).ToList();
        }
    }
}
