using CommunityToolkit.Maui.Alerts;
using MyTravelCopilot.Contracts;
using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Repositories.Login;
using System.Text;

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
        public async Task GoToSignup()
            => await Shell.Current.GoToAsync(nameof(SignupPage));

        [RelayCommand]
        public async Task Login()
        {
            var loginRequest = new LoginRequest(Email, Password);

            var contract = new LoginContract(loginRequest);

            if(!contract.IsValid)
            {
                var messages = contract.Notifications.Select(x=>x.Message);
                var sb = new StringBuilder();

                foreach(var message in messages)
                    sb.Append($"{message}\n");

                await Shell.Current.DisplayAlert("Attention", sb.ToString(), "OK");
                return;
            }

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
