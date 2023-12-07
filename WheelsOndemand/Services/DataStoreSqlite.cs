

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
            await SaveCarAsync(new Car() { Model = "Rav 4", Image="rav4.png", Price=100, Year=2020 });
            await SaveCarAsync(new Car() { Model = "Audi", Image = "audi.jpg", Price = 110 , Year = 2022 });
            await SaveCarAsync(new Car() { Model = "Ram", Image = "ram.jpg", Price = 100, Year = 2019 });
            await SaveCarAsync(new Car() { Model = "Mazda", Image = "mazda.jpg", Price = 90, Year = 2018 });
            await SaveCarAsync(new Car() { Model = "Dough", Image = "dough.jpg", Price = 120, Year = 2021 });
            await SaveCarAsync(new Car() { Model = "Rough", Image = "nissanrough.jpg", Price = 100, Year = 2020 });
            await SaveCarAsync(new Car() { Model = "BMW", Image = "bmw.jpg", Price = 150, Year = 2022 });
            await SaveCarAsync(new Car() { Model = "Lembergini", Image = "lembergini.jpg", Price = 200, Year = 2019 });
            await SaveCarAsync(new Car() { Model = "Mercedes", Image = "mercedes.jpg", Price = 180, Year = 2020 });
            await SaveCarAsync(new Car() { Model = "Rough", Image = "rough.png", Price = 90, Year = 2021 });
            await SaveCarAsync(new Car() { Model = "Elentra", Image = "elentra.png", Price = 110, Year = 2020 });
            await SaveCarAsync(new Car() { Model = "Camry", Image = "camry.png", Price = 130, Year = 2020 });
            await SaveUserAsync(new User() {  Firstname="Pooja", Lastname="Rathod" });
            await SaveUserAsync(new User() { Firstname = "Gurkirpal", Lastname = "Singh" });
            await SaveUserAsync(new User() { Firstname = "Koushik", Lastname = "Reddy" });

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

