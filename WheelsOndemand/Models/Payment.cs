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
        [MaxLength(20),NotNull]
        public string FirstName { get; set; }
        [MaxLength(20),NotNull]
        public string LastName { get; set; }
        [MaxLength(10),NotNull]
        public int MobileNumber { get; set; }
        [NotNull,MaxLength(75)]
        public string Address { get; set; }
        [MaxLength(3),NotNull] 
        public int CVC { get; set; }
        [MaxLength(16),NotNull]
        public int CardNumber { get; set; }
        [MaxLength(200)]
        public string Comment {  get; set; }
        [NotNull]
        public DateTime ExpiryDate { get; set; }
        [NotNull]
        public DateTime PickupDate { get; set; }
        [NotNull]
        public DateTime PickupTime { get; set; }
        [NotNull]
        public DateTime ReturnDate { get; set; }
        [NotNull]
        public DateTime ReturnTime { get; set; }
        [NotNull]
        public float Price { get; set; }
        public float Tax { get; set; }
        public float Finalprice { get; set; }
        public int Carid { get; set; }
        public string Carname { get; set; }
       
    }
}
