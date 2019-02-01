using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    public class Magic
    {
        public int UserID { get; set; }
        public string PhoneBook { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string HomeAdress { get; set; }
        public int Post { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public int eMailAddress { get; set; }

        public Magic()
        {

        }
        public Magic(int userID)
        {
           UserID = userID;
        }
        public Magic(int userID, string name, string username, int phonenumber, int emailaddress)
        {
            UserID = userID;
            Name = name;
            Username = username;
            PhoneNumber = phonenumber;
            eMailAddress = emailaddress;
        }
        public Magic(int userID, string name, string username, string homeasress, int post, string city, int phonenumber, int emailaddress)
        {
            UserID = userID;
            Name = name;
            Username = username;
            HomeAdress = homeasress;
            Post = post;
            City = city;
            PhoneNumber = phonenumber;
            eMailAddress = emailaddress;
        }
        public Magic(string phonebook, int userID, string name, string username, string homeasress, int post, string city, int phonenumber, int emailaddress)
        {
            PhoneBook = phonebook;
            UserID = userID;
            Name = name;
            Username = username;
            HomeAdress = homeasress;
            Post = post;
            City = city;
            PhoneNumber = phonenumber;
            eMailAddress = emailaddress;
        } 
    }
}
