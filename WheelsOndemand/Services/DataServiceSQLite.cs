using WheelsOndemand.Models;
using SQLite;
using System.Collections.ObjectModel;

namespace WheelsOndemand.Services
{
    public class DataServiceSQLite
    {
        private static DataServiceSQLite _instance;
        public static DataServiceSQLite Instance => _instance ??= new DataServiceSQLite();

        private SQLiteAsyncConnection _database;

        private const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        private static string DatabaseFile => Path.Combine(FileSystem.AppDataDirectory, "Data.db3");

        private DataServiceSQLite()
        {
        }

        private async Task Init()
        {
            if (_database == null)
            {
                File.Delete(DatabaseFile); //This is a temporary line to delete the database every time. Remove this line to retain data.

                _database = new SQLiteAsyncConnection(DatabaseFile, Flags);

                if (!File.Exists(DatabaseFile))
                {
                    //Create tables and add sample data if needed.
                    await _database.CreateTableAsync<Car>();                


                    await SaveAsync(new Car() { Model = "Rav 4", Image = "rav4.png", Price = 100, Year = 2020 });
                    await SaveAsync(new Car() { Model = "Audi", Image = "audi.jpg", Price = 110, Year = 2022 });
                    await SaveAsync(new Car() { Model = "Ram", Image = "ram.jpg", Price = 100, Year = 2019 });
                    await SaveAsync(new Car() { Model = "Mazda", Image = "mazda.jpg", Price = 90, Year = 2018 });
                    await SaveAsync(new Car() { Model = "Dough", Image = "dough.jpg", Price = 120, Year = 2021 });
                    await SaveAsync(new Car() { Model = "Rough", Image = "nissanrough.jpg", Price = 100, Year = 2020 });
                    await SaveAsync(new Car() { Model = "BMW", Image = "bmw.jpg", Price = 150, Year = 2022 });
                    await SaveAsync(new Car() { Model = "Lembergini", Image = "lembergini.jpg", Price = 200, Year = 2019 });
                    await SaveAsync(new Car() { Model = "Mercedes", Image = "mercedes.jpg", Price = 180, Year = 2020 });
                    await SaveAsync(new Car() { Model = "Rough", Image = "rough.png", Price = 90, Year = 2021 });
                    await SaveAsync(new Car() { Model = "Elentra", Image = "elentra.png", Price = 110, Year = 2020 });


                    await _database.CreateTableAsync<User>();
                    await SaveAsync(new User() { Firstname = "Pooja", Lastname = "Rathod", Username = "pooja", Password = "rathod", IsAdmin = true });
                    await SaveAsync(new User() { Firstname = "Gurkirpal", Lastname = "Singh", Username = "gurkirpal", Password = "singh", IsAdmin = true });
                    await SaveAsync(new User() { Firstname = "Koushik", Lastname = "Reddy", Username = "koushik", Password = "reddy", IsAdmin = false });
                }
            }
        }

        public async Task<ObservableCollection<T>> GetAsync<T>() where T : new()
        {
            await Init();
            var result = await _database.Table<T>().ToListAsync();
            return new ObservableCollection<T>(result);
        }

        public async Task<T> GetAsync<T>(int id) where T : IEntity, new()
        {
            await Init();
            return await _database.Table<T>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveAsync<T>(T item) where T : IEntity, new()
        {
            await Init();
            if (item.Id != 0)
            {
                return await _database.UpdateAsync(item);
            }
            else
            {
                return await _database.InsertAsync(item);
            }
        }

        public async Task<int> DeleteAsync<T>(T item) where T : new()
        {
            await Init();
            return await _database.DeleteAsync(item);
        }
    }
}
