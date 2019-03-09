using System.Data.SQLite;

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
        public string eMailAddress { get; set; }  

        public Oseba(int userID)
        {
            UserID = userID;
        }

        public Oseba(int phonebook_id, string name, string username, string homeadress, int post, string city, int phonenumber, string emailaddress)
        {
            PhoneBook_id = phonebook_id;
            Name = name;
            Username = username;
            HomeAdress = homeadress;
            Post = post;
            City = city;
            PhoneNumber = phonenumber;
            eMailAddress = emailaddress;
        }

        public Oseba(int phonebook_id, int userID, string name, string username, string homeadress, int post, string city, int phonenumber, string emailaddress)
        {
            PhoneBook_id = phonebook_id;
            UserID = userID;
            Name = name;
            Username = username;
            HomeAdress = homeadress;
            Post = post;
            City = city;
            PhoneNumber = phonenumber;
            eMailAddress = emailaddress;
        }
         
    }

    public class Imeniki
    {
        public int PhoneBook_id { get; set; } 
        public string PhoneBook { get; set; }

        public Imeniki(int phonebook_id, string phonebook)
        {
            PhoneBook_id = phonebook_id;
            PhoneBook = phonebook; 
        } 
    }

    public class Database
    {
        private SQLiteConnection con;

        public Database()
        {
            con = new SQLiteConnection("datasource=Database.db");
            con.Open();
        }
        

        public bool AddOseba(Oseba toAdd)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "";//SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
                return true;
        }

        public bool UpdateOseba(Oseba toUpdate)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "";//SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
            return true;
        }

        public bool DeleteOseba(Oseba toDelete)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "";//SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
            return true;
        }

        public bool AddImenik(Imeniki toAdd)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "";//SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
            return true;
        }


        /* Tle je pa zdej treba mal več deča*/


        public Oseba ShowOsebe(Oseba toShow)
        {
            Oseba toReturn = null;
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "";//SQL STAVEK 
                using (SQLiteDataReader reader = com.ExecuteReader())
                while (reader.HasRows)
                {
                        reader.Read();
                        toReturn = new Oseba(reader.Getint32(0), reader.Getstring(1));//Pač tle se pol napiše kam kaj shrani
                        //Pač rakroli izpiše
                }
                com.Dispose();
            }
            return toReturn;
        }

        public Imeniki showImenik(Imeniki toShow)
        {
            Imeniki toReturn = null;
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "";//SQL STAVEK 
                using (SQLiteDataReader reader = com.ExecuteReader())
                    while (reader.HasRows)
                    {
                        reader.Read();
                        toReturn = new Imeniki(reader.Getint32(0), reader.Getstring(1));//Pač tle se pol napiše kam kaj shrani
                                                                                      //Pač rakroli izpiše
                    }
                com.Dispose();
            }
            return toReturn;
        }

    }

    /*
        public int populate(int phonebook_id, string phonebook)
        {
            PhoneBook_id = phonebook_id;
            con = new SQLiteConnection("datasource=Database.db");
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT ime FROM imeniki";
                SQLiteDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                }
                com.Dispose();
                reader.Close();
                return 0;
            } 
        }
    */
    }





