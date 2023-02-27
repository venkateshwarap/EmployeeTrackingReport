using Employee.DataModel.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using System.Net.Http;

namespace EmployeeTrackingApp.Service
{
    public class DashboardService
    {
        private readonly HttpClient _httpClient;
        public DashboardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Employees>> GetEmployeeDetails()
        {
           var emp=  await _httpClient.GetFromJsonAsync<Employees[]>(AppSettings.DashboardList);
            return emp;
        }


        //public async Task<List<Employees>> GetEmployeeDetails()
        //{
        //     List<Employees> employees;

        //    try
        //    {
        //        List<Employees>  employees = new List<Employees>();
        //        var response = await _httpClient.GetAsync(AppSettings.DashboardAPI);
        //        employees = JsonConvert.DeserializeObject<List<Employees>>(await response.Content.ReadAsStringAsync());
        //        return employees;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        // }
    }
}
