using Employee.DataModel.Models;
using EmployeeTrackingApp.Service;

namespace EmployeeTrackingApp.Pages
{
    public partial class AddEmployee
    {
        EmployeeModel employeeModel { get; set; }
        EmployeeApiService employeeApiService = new EmployeeApiService();
        protected override void OnInitialized()
        {
            employeeModel = new EmployeeModel();
        }
        public async void SaveEmployeeDetails()
        {

            var response = await employeeApiService.AddEmployeeDetails(employeeModel);
                        
        }
    }
}
