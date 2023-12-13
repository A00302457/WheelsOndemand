using System.Collections.ObjectModel;
using System.Diagnostics;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WheelsOndemand.Models;
using WheelsOndemand.Services;
using WheelsOndemand.Views;

namespace WheelsOndemand.ViewModels
{
    public class CreateAccountViewModel : ObservableRecipient
    {
        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string _confirmPassword;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                _confirmPassword = value;
                OnPropertyChanged(nameof(ConfirmPassword));
            }
        }


        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }




        protected static DataServiceSQLite Database => DataServiceSQLite.Instance;
       protected static AuthenticationserviceFirebase Authentication => AuthenticationserviceFirebase.Instance;

        public IAsyncRelayCommand AppearingCommand { get; }
        public IAsyncRelayCommand CreateAccountCommand { get; }

        public IAsyncRelayCommand CancelCommand { get; }

        public CreateAccountViewModel()
        {
            AppearingCommand = new AsyncRelayCommand(Appearing);
            CreateAccountCommand = new AsyncRelayCommand(CreateAccount);
            CancelCommand = new AsyncRelayCommand(Cancel);
        }


        private async Task Appearing()
        {
            Email = "";
            Password = "";
            ConfirmPassword = "";
        }

        private async Task CreateAccount()
        {
            if (Password == ConfirmPassword)
            {
                var (success, message) = await Authentication.SignUpAsync(Email, Password);
                Message = message;

                if (success)
                {
                    await Database.SaveAsync<User>(new User() { Email = Email, IsAdmin = false });
                    await Shell.Current.GoToAsync($"///{nameof(Views.LoginView)}");
                }
            }
            else
            {
                Message = "The two passwords are different.";
            }
        }
        private async Task Cancel()
        {

            await Shell.Current.GoToAsync($"///{nameof(Views.LoginView)}");

        }
    }
}