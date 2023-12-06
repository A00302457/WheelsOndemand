using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsOndemand.Models
{
    //The class "Cars_Info" defines six properties: CarID, Car_Image, Car_Brand, Car_Model, Model_Year, and Price_Per_Day.
    //These properties can be used to store information about the cars available for rent, such as their brand,
    //model, year, image, and price per day.
    [SQLite.Table("Cars")]
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int Id{get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }


    }
}
