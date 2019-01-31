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
        public int PhoneBookID { get; set; }
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

        }
        public Magic(int userID, string name, string username, string homeasress, int post, string city, int phonenumber, int emailaddress)
        {

        }
        public Magic(int phonebookid, int userID, string name, string username, string homeasress, int post, string city, int phonenumber, int emailaddress)
        {

        }


    }
}
