using System;
using System.Windows.Forms;
using BlackBox;

namespace Imenik
{
    public partial class ImenikForm : Form
    {
        public ImenikForm()
        {
            InitializeComponent();
        }

        int UserID = 0; // dobi od izbranega objekta 
        int PhoneBook_id = 0; // dobi iz globlane spremenljivke, ki pove, ker id phonebook je trenutno odprt 
        string PhoneBook = "";// dobi iz baze
        string FirstName = "";
        string LastName = "";
        string HomeAdress = "";
        string eMailAddress = "";
        string City = "";
        int Post = 0000;
        int PhoneNumber = 000000000;
        
        int action = 0;

        /// <summary>
        /// IMENIK : možno je imeti več različnih imenikov.
        /// </summary>

        private void SelectPhoneBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Iz baze izpiše vse imenike
        }
        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            action = 1;     // v bazo vpiše vse podatke osebe, v imenik, ki je trenutno izbran
            VpisVBazo();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            action = 2;     // v bazi posodobi podatke osebe, ki je trenutno izbrana
            VpisVBazo();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        { 
            action = 3;     // v bazi izbriše osebo
            VpisVBazo();
           
        }

        private void AddPhoneBookBtn_Click(object sender, EventArgs e)
        {
            action = 4;
            VpisVBazo();    // v bazo vpiše imenik
        }

        private void VpisVBazo ()
        {
            if(action ==4)
            { 
                if (AddPhoneBookTextBox.Text != "" || AddPhoneBookTextBox.Text != null)
                {
                    PhoneBook = AddPhoneBookTextBox.Text;
                }
                else { PhoneBook = ""; }
            }
            else { 
                if (NameTextBox.Text != "" || NameTextBox.Text != null)
                {
                    FirstName = NameTextBox.Text;
                }
                else { FirstName = "";}
                if (SurnameTextBox.Text != "" || SurnameTextBox.Text != null)
                {
                    LastName = SurnameTextBox.Text;
                }
                else { LastName = "";}
                if (HomeAddressTextBox.Text != "" || HomeAddressTextBox.Text != null)
                {
                    HomeAdress = HomeAddressTextBox.Text;
                }
                else { HomeAdress = "";}
                if (PostTextBox.Text != "" || PostTextBox.Text != null)
                {
                    Post = Convert.ToInt32(PostTextBox.Text);
                }
                else { Post = 0000; }
                if (CityTextBox.Text != "" || CityTextBox.Text != null)
                {
                    City = CityTextBox.Text;
                }
                else { City = ""; }
                if (PhoneNumberTextBox.Text != "" || PhoneNumberTextBox.Text != null)
                {
                    PhoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text);
                }
                else { PhoneNumber = 000000000;}
                if (eMailTextBox.Text != "" || eMailTextBox.Text != null)
                {
                    eMailAddress = eMailTextBox.Text;
                }
                else { eMailAddress = "";}
            }

            Oseba newOseba = new Oseba(UserID);
            Oseba newOseba1 = new Oseba(UserID, FirstName, LastName, HomeAdress, Post, City, PhoneNumber, eMailAddress,PhoneBook_id);
            Oseba newOseba2 = new Oseba(FirstName, LastName, HomeAdress, Post, City, PhoneNumber, eMailAddress, PhoneBook_id); 
            Imeniki newImenik = new Imeniki(PhoneBook_id, PhoneBook);

            switch (action)
            {
                case 1: //Zatakne se tlele
                    MessageBox.Show("ShowUp");
                    Database DodajOsebo = new Database();
                    if(DodajOsebo.AddOseba(newOseba2) == true)
                    {
                        MessageBox.Show("Entery Successful!");
                    }
                    // stavek za klic insert funkcije baze
                    break;
                case 2:
                    Database UrediOsebo = new Database();
                    if(UrediOsebo.UpdateOseba(newOseba1) == true)
                    {
                        MessageBox.Show("Edit Successful!");
                    }
                    // stavek za klic update funkcije baze
                    break;
                case 3:
                    Database izbrisOsebe = new Database();
                    if (izbrisOsebe.DeleteOseba(newOseba) == true)
                    {
                        MessageBox.Show("Removal Successful!");
                    }
                    break;
                case 4:
                    Database DodajImenik = new Database();
                    if(DodajImenik.AddImenik(newImenik) == true)
                    {
                        MessageBox.Show("Entery Successful!");
                    }
                    break;
            }
            refresh();
        }

        private void refresh()
        {
            AddPhoneBookTextBox.Text = "";
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            HomeAddressTextBox.Text ="";
            PostTextBox.Text ="";
            CityTextBox.Text ="";
            PhoneNumberTextBox.Text ="";
            eMailTextBox.Text ="";

            MessageBox.Show("Refresh");


        }
    }
}
