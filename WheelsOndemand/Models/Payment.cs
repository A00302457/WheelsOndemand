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
    [SQLite.Table("Payments")]
    internal class Payment : IEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Userid {  get; set; }
        public int number {  get; set; }
        public string Name { get; set; }
        public int CVC { get; set; }
        public string Expirydate {  get; set; }
    }
}
