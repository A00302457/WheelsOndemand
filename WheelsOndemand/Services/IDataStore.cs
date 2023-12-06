
﻿using WheelsOndemand.Models;

namespace WheelsOndemand.Services
{
    interface IDataStore
    {
        Task<List<Car>> GetCarsAsync();
        Task<Car> GetCarAsync(int id);
        Task<int> SaveCarAsync(Car car);

        Task<int> DeleteCarAsync(Car car);

        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<int> SaveUserAsync(User user);
        Task<int> DeleteUserAsync(User user);
    }
}
