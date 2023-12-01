using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsOndemand.Models
{
    //The User_Info class definition you provided is an example of a
    //C# class that can be used to store information about users in your application. The class defines ten properties:
    //IsAdmin: A boolean value that indicates whether the user is an administrator or not.
    //User_Id: An integer value that uniquely identifies the user. User_Name: A string value that represents the username of the user.
    //Password: An integer value that represents the password of the user. First_Name: A string value that represents the first name of the user.
    //Name: A string value that represents the full name of the user. Description: A string value that represents a description of the user.
    //Email: A string value that represents the email address of the user. Phone: A string value that represents the phone number of the user.
    //Address: A string value that represents the address of the user. By creating an instance of the User_Info class for each user in your application,
    //you can store all the relevant information about the user in one place.This can make it easier to manage your users and keep track of their information.
    internal class User_Info
    {
        public bool IsAdmin { get; set; }
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public int Password { get; set; }
        public string First_Name { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
       
    }
}
