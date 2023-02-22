using Employee.DataModel.CustomModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using static EmployeeTrackingApp.Pages.Login;

namespace EmployeeTrackingApp.Service
{
    public class UserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private static string EncryptPass(string security)
        {
            var salt = "997eff51db1544c7a3c2ddeb2053f052";
            var md5 = new HMACMD5(Encoding.UTF8.GetBytes(salt + security));
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(security));
            return System.Convert.ToBase64String(data);
        }
        //public async Task<HttpResponseMessage> Login(string Email, string Password)
        public async Task<HttpResponseMessage> Login(LoginModel model)
        {
            model.security = EncryptPass(model.security);
            var loginAsJson = JsonSerializer.Serialize(model);
            var stringclient = new StringContent(loginAsJson, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(AppSettings.LoginAPI,stringclient);
            //var responseModel = JsonSerializer.Deserialize<ResponseModel>(await response.Content.ReadAsStringAsync());
            return response;
        }
    }
}
