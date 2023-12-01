using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsOndemand.Models
{
    /*The Invoive_Info class
        that can be used to store information about invoices in your application. The class defines eleven properties: 
        invoice_Id, User_id, Pickup_Date, Pickup_Time, Return_Date, Return_Time, Price, Tax, Final_Price, Car_Id, and Payment_Card_Id.
        By creating an instance of the Invoive_Info class for each invoice in application, 
        you can store all the relevant information about the invoice in one place.This can make it easier 
        to manage your invoices and keep track of their information.*/
    internal class Invoive_Info
    {
        public int invoice_Id { get; set; }
        public int User_id {  get; set; }
        public string Pickup_Date {  get; set; }
        public string Pickup_Time {  get; set; }
        public string Return_Date { get; set; }
        public string Return_Time { get; set; }        
        public float Price {  get; set; }
        public float Tax {  get; set; }
        public float Final_Price {  get; set; } 
        public int Car_Id { get; set; }
        public int Payment_Card_Id {  get; set; }
    }
}
