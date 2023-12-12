using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsOndemand.Models;
using WheelsOndemand.Services;
using SQLite;

namespace WheelsOndemand.ViewModels
{
    internal class IEntityViewModel : ObservableRecipient
    {
        protected static DataServiceSQLite Database => DataServiceSQLite.Instance;

        public ObservableCollection<IEntity> IEntyties { get; set; }

        public IAsyncRelayCommand GetCommand { get; }
        public IAsyncRelayCommand InsertCommand { get; }

        public IEntityViewModel()
        {
            GetCommand = new AsyncRelayCommand(Get);
            InsertCommand = new AsyncRelayCommand<IEntity>(Insert);
        }

        private async Task Get()
        {
           // IEntyties = await Database.GetAsync<IEntity>();
            OnPropertyChanged(nameof(IEntyties));
        }

        private async Task Insert(IEntity ientyties)
        {
            //await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.Payment)}?id={car.Id}");
        }
    }
}
