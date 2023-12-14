using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WheelsOndemand.Models;
using WheelsOndemand.Services;
using WheelsOndemand.Views;

namespace WheelsOndemand.ViewModels
{
    public class AdminLoginListViewModel : ObservableRecipient
    {
        protected static DataServiceSQLite Database => DataServiceSQLite.Instance;

        public ObservableCollection<AdminLogin> AdminLogins { get; set; }

        public IAsyncRelayCommand GetCommand { get; }
        public IAsyncRelayCommand AddCommand { get; }
        public IAsyncRelayCommand EditCommand { get; }

        public AdminLoginListViewModel()
        {
            GetCommand = new AsyncRelayCommand(Get);
            AddCommand = new AsyncRelayCommand(Add);
            EditCommand = new AsyncRelayCommand<AdminLogin>(Edit);
        }

        private async Task Get()
        {
            AdminLogins = await Database.GetAsync<AdminLogin>();
            OnPropertyChanged(nameof(AdminLogins));
        }

        private async Task Add()
        {
            await Shell.Current.GoToAsync($"///{nameof(Views.AdminLogin)}");
        }

        private async Task Edit(AdminLogin adminLogin)
        {
            await Shell.Current.GoToAsync($"///{nameof(Views.AdminLogin)}?id={adminLogin.Id}");
        }
    }
}