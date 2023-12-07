using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WheelsOndemand.Models;
using WheelsOndemand.Services;

namespace WheelsOndemand.ViewModels
{
    public class LoginViewModel : ObservableRecipient
    {
        protected static DataServiceSQLite Database => DataServiceSQLite.Instance;

        public IAsyncRelayCommand SignInCommand { get; }
        
        public IAsyncRelayCommand CreateAccountCommand { get; }

        public LoginViewModel()
        {
            SignInCommand = new AsyncRelayCommand(SignIn);
            CreateAccountCommand = new AsyncRelayCommand(CreateAccount);
        }

        private async Task SignIn()
        {
            var users = await Database.GetAsync<User>();

            //Add logic here to check if the username and password they typed are in the list of users (variable users above is a list of all users).

            //If the username and password are correct then check if they are an admin, if not, show an error message.

            //Is the user an admin? Go to a different page for admin vs normal users:

            //Yes admin - Go to the admin area.
            //await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.ADMINVIEWHERE)}");

            //Not admin - go to the car list.
            await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.CarListView)}");
        }

        private async Task CreateAccount()
        {
            //Take the user to a CreateAccount page.
           //await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.CREATEACCOUNTVIEWHERE)}");
        }
    }
}