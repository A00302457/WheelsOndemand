﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsOndemand.Models;
using WheelsOndemand.Services;

namespace WheelsOndemand.ViewModels
{
    internal class PaymentViewModel : ObservableRecipient, IQueryAttributable
    {
        protected static DataServiceSQLite Database => DataServiceSQLite.Instance;

        private Payment _payment;
        public Payment Payment
        {
            get { return _payment; }
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(Payment));
            }
        }
        public IAsyncRelayCommand InsertCommand { get; }

        public PaymentViewModel()
        {
            InsertCommand = new AsyncRelayCommand<Payment>(Insert);
        }

        private async Task Insert(Payment payment)
        {
            //await Shell.Current.GoToAsync($"///{nameof(WheelsOndemand.Views.Payment)}?id={car.Id}");
        }

        public async void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Payment = new Payment();

            //throw new NotImplementedException();
            var id = Convert.ToInt32(query["id"]);

            Car car = await Database.GetAsync<Car>(id);

            Payment.Carid = id;
            Payment.Carname = $"{car.Brand} {car.Model} {car.Year}";

            OnPropertyChanged(nameof(Payment));
        }
    }
}

