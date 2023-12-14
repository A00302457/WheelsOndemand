using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WheelsOndemand.Models;
using WheelsOndemand.Services;
using WheelsOndemand.Views;

namespace WheelsOndemand.ViewModels
{
    public class LoginViewModel : ObservableRecipient
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
        public IAsyncRelayCommand SignInCommand { get; }
        public IAsyncRelayCommand CreateAccountCommand { get; }


        public LoginViewModel()
        {
            AppearingCommand = new AsyncRelayCommand(Appearing);
            SignInCommand = new AsyncRelayCommand(SignIn);
            CreateAccountCommand = new AsyncRelayCommand(CreateAccount);
        }

        private async Task Appearing()
        {
            Email = "";
            Password = "";
        }

        //CYA ActivityListView and ActivityListViewModel -> AdminCarListView and AdminCarListViewModel
        //CYA ActivityDetailView and ActivityDetailViewModel -> AdminCarDetailView and AdminCarDetailViewModel

        private async Task SignIn()
        {
            var (success, message) = await Authentication.SignInAsync(Email, Password);
            Message = message;

            if (success)
            {
                var users = new List<User>(await Database.GetAsync<User>());
                
                LoginSession.LoggedInUser = users.Find(user => user.Email == Email);


                if (LoginSession.LoggedInUser != null && LoginSession.LoggedInUser.IsAdmin)
                {
                    // Go to AdminCarListView

                }
                await Shell.Current.GoToAsync($"///{nameof(Views.CarListView)}");
            }
        }
        private async Task CreateAccount()
        {
            await Shell.Current.GoToAsync($"///{nameof(Views.CreateAccountView)}");

        }
    }
}