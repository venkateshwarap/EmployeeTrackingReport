//using Employee.DataModel.Models;
//using EmployeeTrackingApp.Service;

//namespace EmployeeTrackingApp.Pages
//{
//    public partial class AddEmployee
//    {
//        public EmployeeModel[] getEmployeeModel { get; set; }
//        public EmployeeModel employeeModel { get; set; }

//        EmployeeApiService employeeApiService = new EmployeeApiService();
//        protected override async Task OnInitializedAsync()
//        {
//            employeeModel = new EmployeeModel();
//            HttpClient httpClient = new HttpClient();
//            var response = await httpClient.GetAsync("https://localhost:7024/api/Employee/GetAllEmployee");
//            if (response.IsSuccessStatusCode)
//            {
//                var data = await response.Content.ReadFromJsonAsync<EmployeeModel[]>();
//                getEmployeeModel = data;
//                // Use the data as needed
//            }
//        }
//        public async void SaveEmployeeDetails()
//        {
//            var response = await employeeApiService.AddEmployeeDetails(employeeModel);
                        
//        }
//    }
//}
