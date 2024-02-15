using CommunityToolkit.Maui.Alerts;
using MyTravelCopilot.Models.Request;
using MyTravelCopilot.Repositories.Signup;

namespace MyTravelCopilot.ViewModels
{
    public partial class SignupViewModel : BaseViewModel
    {
        [ObservableProperty]
        string name;

        [ObservableProperty]
        string email;

        [ObservableProperty]
        string password;

        private readonly ISignupRepository _signupRepository;

        public SignupViewModel(ISignupRepository signupRepository)
        {
            _signupRepository = signupRepository;
        }

        [RelayCommand]
        public async Task Signup()
        {
            var request = new SignupRequest(name, email, password);
            var result = await _signupRepository.CreateAsync(request);

            if (result)
            {
                var toast = Toast.Make("Registered Successfully!", CommunityToolkit.Maui.Core.ToastDuration.Long);
                await toast.Show();
                await Shell.Current.GoToAsync("..");
            }
            else
            {
                var toast = Toast.Make("An error occurred while registering a user", CommunityToolkit.Maui.Core.ToastDuration.Long);
                await toast.Show();
            }
        }
    }
}
