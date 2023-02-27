using Employee.DataModel.Models;
using EmployeeTrackingApp.Data;
using EmployeeTrackingApp.Service;
using Microsoft.JSInterop;

namespace EmployeeTrackingApp.Pages
{
    public partial class Login
    {
       
        public LoginModel model = new LoginModel();
       
        HttpClient _httpClient = new HttpClient();

        private async Task Authenticate()
        {
          
            UserService service = new UserService(_httpClient);
            var result = await service.Login(model);
        
            var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
            await customAuthStateProvider.UpdateAuthenticationState(new LoginModel
            {
                UserName = model.UserName
               
            });

            if (result.IsSuccessStatusCode)
            {
                navManager.NavigateTo("/dashboard", true);
            }
            else
            {
                //navManager.NavigateTo("/login");
                model.IsValidLogin = false;
            }

        }
    }
}
