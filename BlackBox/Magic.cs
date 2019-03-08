﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBox
{
    public class Oseba
    {
        public int UserID { get; set; }
        public int PhoneBook_id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string HomeAdress { get; set; }
        public int Post { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public int eMailAddress { get; set; }

        public Oseba(int userID)
        {
            UserID = userID;
        }

        public Oseba(int userID, string name, string username, string homeasress, int post, string city, int phonenumber, int emailaddress)
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

        public Oseba(int phonebook_id, int userID, string name, string username, string homeasress, int post, string city, int phonenumber, int emailaddress)
        {
            PhoneBook_id = phonebook_id;
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

    public class Imeniki //database
    {
        public int PhoneBook_id { get; set; }
        public string PhoneBook { get; set; }
    }

}
        


