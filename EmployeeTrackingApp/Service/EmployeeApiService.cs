//using Azure.Core;
//using Azure;
//using Employee.DataModel.CustomModel;
//using Employee.DataModel.Models;
//using Microsoft.Office.Interop.Excel;
//using Syncfusion.Blazor.Diagram;
//using System.Drawing;
//using System.Net.Http;
//using System.Runtime.Intrinsics.X86;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace EmployeeTrackingApp.Service
//{
//    public class EmployeeApiService
//    {
//        HttpClient client = new HttpClient();
//        public async Task<HttpResponseMessage> AddEmployeeDetails(EmployeeModel employeeModel)
//        {
//            HttpResponseMessage response = await client.PostAsJsonAsync("https://localhost:7024/api/Employee/SaveEmployee", employeeModel);
//            if (response.IsSuccessStatusCode)
//            {
//                string responseContent = await response.Content.ReadAsStringAsync();
                
//            }
//           return response;

//        }
//    }
//}
