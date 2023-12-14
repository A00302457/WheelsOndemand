﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WheelsOndemand.Models;
using WheelsOndemand.Services;
using WheelsOndemand.Views;

namespace WheelsOndemand.ViewModels
{
    public class CarDetailsViewModel : ObservableObject, IQueryAttributable
    {
        protected static DataServiceSQLite Database => DataServiceSQLite.Instance;

        private Car _car;
        public Car Car
        {
            get { return _car; }
            set
            {
                _car = value;
                OnPropertyChanged(nameof(Car));
            }
        }
        public IAsyncRelayCommand AppearingCommand { get; }
        public IAsyncRelayCommand SaveCommand { get; }
        public IAsyncRelayCommand DeleteCommand { get; }
        public IAsyncRelayCommand CancelCommand { get; }

        public CarDetailsViewModel()
        {
            AppearingCommand = new AsyncRelayCommand(Appearing);
            SaveCommand = new AsyncRelayCommand(Save);
            DeleteCommand = new AsyncRelayCommand(Delete);
            CancelCommand = new AsyncRelayCommand(Cancel);
        }

        private async Task Appearing()
        {
            if (_car == null)
            {
                _car = new Car();
                OnPropertyChanged(nameof(Car));
            }
        }

        private async Task Save()
        {
            await Database.SaveAsync<Car>(_car);
            await Shell.Current.GoToAsync($"///{nameof(Views.CarListView)}");
        }

        private async Task Delete()
        {
            await Database.DeleteAsync<Car>(_car);
            await Shell.Current.GoToAsync($"///{nameof(Views.CarListView)}");
        }

        private async Task Cancel()
        {
            await Shell.Current.GoToAsync($"///{nameof(Views.CarListView)}");
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (!query.ContainsKey("id"))
                return;

            var id = Convert.ToInt32(query["id"].ToString());
            Get(id);
        }

        private async void Get(int id)
        {
            _car = await Database.GetAsync<Car>(id);
            OnPropertyChanged(nameof(Car));
        }
    }
}