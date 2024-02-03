using CommunityToolkit.Maui.Alerts;
using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Repositories.Login;

namespace MyTravelCopilot.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        string email;
        [ObservableProperty]
        string password;

        private readonly ILoginRepository _loginRepository;
        public LoginViewModel(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [RelayCommand]
        public async Task Login()
        {
            var loginRequest = new LoginRequest(Email, Password);
            var result = await _loginRepository.LoginAsync(loginRequest);

            if (result is null || string.IsNullOrEmpty(result.accessToken))
            {
                var toast = Toast.Make("Login failed, try again!", CommunityToolkit.Maui.Core.ToastDuration.Long);
                await toast.Show();
                return;
            }
        }
    }
}
