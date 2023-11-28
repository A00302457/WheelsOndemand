using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsOndemand.Models
{
    internal class Invoive_Info
    {
        public string First_Name { get; set; }
        public string Last_Nmae { get; set; }
        public string Description {  get; set; }
        public float Price {  get; set; }
        public float Tax {  get; set; }
        public float Final_Price {  get; set; } 

           public int Mobile_No { get; set; }
        public string Email_Id {  get; set; }
    }
}
