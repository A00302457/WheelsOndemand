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

        public ObservableCollection<Car> Cars { get; set; }

        public IAsyncRelayCommand GetCommand { get; }
        public IAsyncRelayCommand SelectCommand { get; }

        public CarListViewModel()
        {
            GetCommand = new AsyncRelayCommand(Get);
            SelectCommand = new AsyncRelayCommand<Car>(Select);
        }

        private async Task Get()
        {
            Cars = await Database.GetAsync<Car>();
            OnPropertyChanged(nameof(Cars));
        }

        private async Task Select(Car car)
        {
            await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.Payment)}?id={car.Id}");
        }
    }
}