using System;
using System.Collections.Generic;

﻿using WheelsOndemand.Services;
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WheelsOndemand.Models;

namespace WheelsOndemand.ViewModels
{
    internal class CarListViewModel
    {
        public IDataStore SqliteDataStore => DependencyService.Get<IDataStore>();
        public ObservableRangeCollection<Car> Cars { get; set; }
        public ICommand PageAppearingCommand { get; set; }
        public ICommand SelectCommand { get; }
        public ICommand AddCommand { get; }

        public CarListViewModel()
        {
            Cars = new ObservableRangeCollection<Car>();
            PageAppearingCommand = new AsyncRelayCommand(PageAppearing);
            SelectCommand = new AsyncRelayCommand<Car>(SelectAsync);
            AddCommand = new AsyncRelayCommand(AddAsync);
        }

        private async Task SelectAsync(Car car)
        {
            if (car != null)
                await Shell.Current.GoToAsync($"{nameof(Views.Payment)}?id={car.Carid}");
        }

        private async Task AddAsync()
        {
            await Shell.Current.GoToAsync(nameof(Views.Payment));
        }

        public async Task Refresh()
        {
            var cars = await SqliteDataStore.GetCarsAsync();
            //Cars.Clear();
            //Cars.AddRange(new List<Car>(cars.Select(car => new Car(car))));
        }

        public async Task PageAppearing()
        {
            await Refresh();
        }
    }
}
