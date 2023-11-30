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
    internal class Cars_Info
    {
      
        public int CarID {  get; set; }
        public string Car_Image { get; set; }
        public string Car_Brand { get; set; }
        public string Car_Model { get; set; }
        public int Model_Year { get; set; }
        public int Price_Per_Day { get; set; }


    }
}
