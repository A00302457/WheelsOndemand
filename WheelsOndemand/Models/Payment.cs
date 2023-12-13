using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WheelsOndemand.Models
{
    //The Payment_Card class definition that can be used to store information about payment cards in my application.
    //The class defines six properties: PaymentCard_Id, User_Id, number, Name, CVC, and Expiry_Date.
    // By creating an instance of the Payment_Card class for each payment card in application,
    // you can store all the relevant information about the payment card in one place.This can make it easier
    // to manage your payment cards and keep track of their information.
    [SQLite.Table("Payment")]
    internal class Payment : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Userid { get; set; }
        public int PaymentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int CVC { get; set; }
        public int CardNumber { get; set; }
        public string Comment {  get; set; }
        public string ExpiryDate { get; set; }
        public string PickupDate { get; set; }
        public string PickupTime { get; set; }
        public string ReturnDate { get; set; }
        public string ReturnTime { get; set; }
        public float Price { get; set; }
        public float Tax { get; set; }
        public float Finalprice { get; set; }
        public int Carid { get; set; }
        public string Carname { get; set; }
       
    }
}
