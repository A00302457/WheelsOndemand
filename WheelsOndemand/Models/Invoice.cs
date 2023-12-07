using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WheelsOndemand.Models
{
    /*The Invoive_Info class
        that can be used to store information about invoices in your application. The class defines eleven properties: 
        invoice_Id, User_id, Pickup_Date, Pickup_Time, Return_Date, Return_Time, Price, Tax, Final_Price, Car_Id, and Payment_Card_Id.
        By creating an instance of the Invoive_Info class for each invoice in application, 
        you can store all the relevant information about the invoice in one place.This can make it easier 
        to manage your invoices and keep track of their information.*/
    [SQLite.Table("Invoices")]
    internal class Invoice : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Userid {  get; set; }
        public string Pickupdate {  get; set; }
        public string Pickuptime {  get; set; }
        public string Returndate { get; set; }
        public string Returntime { get; set; }        
        public float Price {  get; set; }
        public float Tax {  get; set; }
        public float Finalprice {  get; set; } 
        public int Carid { get; set; }
        public int Paymentcardid {  get; set; }
    }
}
