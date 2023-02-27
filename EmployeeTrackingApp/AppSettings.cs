using static System.Net.WebRequestMethods;

namespace EmployeeTrackingApp
{
    public static class AppSettings
    {
        public const string WebApiUrl = "https://localhost:7024/api/";
       
        public const string LoginAPI = "https://localhost:7024/api/Authenticate/login";
        public const string DashboardList = "https://localhost:7024/api/Dashboard/GetEmployeeDetails";
        public const string GetPOC = "https://localhost:7024/api/POC/GetPOCDetails";
        public const string GetInterview = "https://localhost:7024/api/Interview/GetInterview";

        public const string Con = "application/json";
    }
}
