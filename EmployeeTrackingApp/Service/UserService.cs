using Employee.DataModel.CustomModel;
using Employee.DataModel.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
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

        private static string EncryptKey(string security)
        {
            var salt = "abcdefghijklmnopqrstuvwxyz";
            var md5 = new HMACMD5(Encoding.UTF8.GetBytes(salt + security));
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(security));
            return System.Convert.ToBase64String(data);
        }
        public async Task<HttpResponseMessage> Login(LoginModel model)
        {
            try
            {
                model.security = EncryptKey(model.security);
                StringContent stringContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, AppSettings.Con);
                var response = await _httpClient.PostAsync(AppSettings.LoginAPI, stringContent);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
