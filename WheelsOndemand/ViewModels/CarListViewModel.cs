using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WheelsOndemand.Models;
using WheelsOndemand.Services;

namespace WheelsOndemand.ViewModels
{
    public class CarListViewModel : ObservableRecipient
    {
        protected static DataServiceSQLite Database => DataServiceSQLite.Instance;

        private string _isAdmin;
        public string IsAdmin
        {
            get { return _isAdmin; }
            set
            {
                _isAdmin = value;
                OnPropertyChanged(nameof(IsAdmin));
            }
        }

        public ObservableCollection<Car> Cars { get; set; }

        public IAsyncRelayCommand AppearingCommand { get; }
        public IAsyncRelayCommand SelectCommand { get; }
        public IAsyncRelayCommand AddCommand { get; }

        public CarListViewModel()
        {
            AppearingCommand = new AsyncRelayCommand(Appearing);
            SelectCommand = new AsyncRelayCommand<Car>(Select);
            AddCommand = new AsyncRelayCommand(Add);


            if (LoginSession.LoggedInUser.IsAdmin)
            {
                _isAdmin = "true";
            }
            else
            {
                _isAdmin = "false";
            }
        }

        private async Task Appearing()
        {
            Cars = await Database.GetAsync<Car>();
            OnPropertyChanged(nameof(Cars));           
        }

        private async Task Add()
        {
            await Shell.Current.GoToAsync($"///{nameof(Views.CarDetailsView)}");
        }

        private async Task Select(Car car)
        {
            if (LoginSession.LoggedInUser.IsAdmin)
            {
                await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.CarDetailsView)}?id={car.Id}");
            }
            else
            {
                await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.Payment)}?id={car.Id}");
            }
        }
    }
}