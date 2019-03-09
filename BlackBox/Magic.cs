using System.Data.SQLite;

namespace BlackBox
{
    public class Oseba
    {
        public int UserID { get; set; }
        public int PhoneBook_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAdress { get; set; }
        public int Post { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public string EMailAddress { get; set; }  

        // Za Delete
        public Oseba(int userID)
        {
            UserID = userID;
        }
        // Za kreacijo nove osebe
        public Oseba(string firstName, string lastName, string homeadress, int post, string city, int phonenumber, string emailaddress, int phonebook_id)
        {
            PhoneBook_id = phonebook_id;
            FirstName = firstName;
            LastName = lastName;
            HomeAdress = homeadress;
            Post = post;
            City = city;
            PhoneNumber = phonenumber;
            EMailAddress = emailaddress;
        }
        // Za urejanje/izpisovanje osebe
        public Oseba(int userID, string firstName, string lastName, string homeadress, int post, string city, int phonenumber, string emailaddress, int phonebook_id)
        {
            PhoneBook_id = phonebook_id;
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            HomeAdress = homeadress;
            Post = post;
            City = city;
            PhoneNumber = phonenumber;
            EMailAddress = emailaddress;
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

        public Database() // Deklariranje baze
        {
            con = new SQLiteConnection("datasource=Database.db");
            con.Open();
        }
        

        public bool AddOseba(Oseba toAdd)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText =   "INSERT INTO osebe (FirstName, LastName, HomeAddress, Post, City, PhoneNumber, EMailAddress, PhoneBook_id)" +
                                    "VALUES ('"+ toAdd.FirstName + "', '" + toAdd.LastName + "','" + toAdd.HomeAdress + "', '" + toAdd.Post + "', '" + toAdd.City + "','" + toAdd.PhoneNumber + "','" + toAdd.EMailAddress + "', '" + toAdd.PhoneBook_id + "')";//SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
                return true;
        }

        public bool UpdateOseba(Oseba toUpdate)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "UPDATE osebe SET " +
                    "(ID = '" + toUpdate.UserID + "', " +
                    "FirstName = '" + toUpdate.FirstName + "', " +
                    "LastName = '" + toUpdate.LastName + "', " +
                    "HomeAddress = '" + toUpdate.HomeAdress + "', " +
                    "Post = '" + toUpdate.Post + "', " +
                    "City = '" + toUpdate.City + "', " +
                    "PhoneNumber = '" + toUpdate.PhoneNumber + "', " +
                    "EMailAddress = '" + toUpdate.EMailAddress + "', " +
                    "PhoneBook_id = '" + toUpdate.PhoneBook_id + "')";  //SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
            return true;
        }

        public bool DeleteOseba(Oseba toDelete)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText =   "DELETE FROM osebe WHERE ID = '"+ toDelete.UserID +"'";//SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
            return true;
        }

        public bool AddImenik(Imeniki toAdd)
        {
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText =   "INSERT into imeniki (ID, Name)" +
                                    "VALUES ('"+ toAdd.PhoneBook_id + "','" + toAdd.PhoneBook +"')";//SQL STAVEK
                com.ExecuteNonQuery();
                com.Dispose();
            }
            return true;
        }

         
        /// <summary>
        ///  Tle je pa zdej treba mal več dela... Za izpis oseb in imenikov  
        /// </summary> 

        public Oseba ShowOsebe(Oseba toShow)
        {
            Oseba toReturn = null;
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT * FROM osebe WHERE PhoneBook_id = '" + toShow.PhoneBook_id + "'";//SQL STAVEK 
                using (SQLiteDataReader reader = com.ExecuteReader())
                while (reader.HasRows)
                {
                        reader.Read();
                        toReturn = new Oseba(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7), reader.GetInt32(8));
                        //             Oseba(int userID, string firstName, string lastName, string homeadress, int post, string city, int phonenumber, string emailaddress, int phonebook_id)
                }
                com.Dispose();
            }
            return toReturn;
        }

        public Imeniki ShowImeniki(Imeniki toShow)
        {
            Imeniki toReturn = null;
            using (SQLiteCommand com = new SQLiteCommand(con))
            {
                com.CommandText = "SELECT id, ime FROM imeniki";//SQL STAVEK 
                using (SQLiteDataReader reader = com.ExecuteReader())
                    while (reader.HasRows)
                    {
                        reader.Read();
                        toReturn = new Imeniki(reader.GetInt32(0), reader.GetString(1));
                        //              Imeniki(int phonebook_id, string phonebook)
                    }
                com.Dispose();
            }
            return toReturn;
        }
    }
}





