

﻿using  WheelsOndemand.Models;
using SQLite;

namespace WheelsOndemand.Services
{
    class DataStoreSqlite : IDataStore
    {
        SQLiteAsyncConnection Database;

        private const string DatabaseFilename = "WheelsOndemand.db3";

        private const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;

        private static string DatabasePath => Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(DatabasePath, Flags);

            if (File.Exists(DatabasePath))
                return;

            await Database.CreateTableAsync<Car>();
            await Database.CreateTableAsync<User>();

            await InsertSampleData();
        }

        private async Task InsertSampleData()
        {
            await SaveCarAsync(new Car() {  Brand="Rav 4", Image="rav4.png", Model="2020", Price=100, Year=2020 });
            await SaveCarAsync(new Car() { Brand = "Rav 5", Image = "rav4.png", Model = "2020", Price = 100, Year = 2020 });
            await SaveCarAsync(new Car() { Brand = "Rav 6", Image = "rav4.png", Model = "2020", Price = 100, Year = 2020 });
            await SaveCarAsync(new Car() { Brand = "Rav 7", Image = "rav4.png", Model = "2020", Price = 100, Year = 2020 });
            await SaveCarAsync(new Car() { Brand = "Rav 8", Image = "rav4.png", Model = "2020", Price = 100, Year = 2020 });
            await SaveUserAsync(new User() {  Firstname="abc", Lastname="xyz" });
            await SaveUserAsync(new User() { Firstname = "abc1", Lastname = "xyz1" });

        }

        public async Task<List<Car>> GetCarsAsync()
        {
            await Init();
            return await Database.Table<Car>().ToListAsync();
        }

        public async Task<Car> GetCarAsync(int id)
        {
            await Init();
            return await Database.Table<Car>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveCarAsync(Car car)
        {
            await Init();
            if (car.Id != 0)
            {
                return await Database.UpdateAsync(car);
            }
            else
            {
                return await Database.InsertAsync(car);
            }
        }

        public async Task<int> DeleteCarAsync(Car car)
        {
            await Init();
            return await Database.DeleteAsync(car);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            await Init();
            return await Database.Table<User>().ToListAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            await Init();
            return await Database.Table<User>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveUserAsync(User user)
        {
            await Init();
            if (user.Id != 0)
            {
                return await Database.UpdateAsync(user);
            }
            else
            {
                return await Database.InsertAsync(user);
            }
        }

        public async Task<int> DeleteUserAsync(User user)
        {
            await Init();
            return await Database.DeleteAsync(user);
        }
    }
}

