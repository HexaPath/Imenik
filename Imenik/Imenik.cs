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
        string FirstName = "";
        string LastName = "";
        string HomeAdress = ""; 
        string City = "";
        int Post = 0000;
        int PhoneNumber = 000000000;
        string eMailAddress = "";
        int action = 0;

        /// <summary>
        /// IMENIK : možno je imeti več različnih imenikov.
        /// </summary>

        private void SelectPhoneBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Iz baze izpiše vse imenike
        }

        private void AddPhoneBookBtn_Click(object sender, EventArgs e)
        {
            // v bazo vpiše imenik
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            action = 1;
            // v bazo vpiše vse podatke osebe, v imenik, ki je trenutno izbran
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            action = 2;
            // v bazi posodobi podatke osebe, ki je trenutno izbrana
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Oseba oseba = new Oseba(UserID); 
            // v bazi izbriše osebo
        }

        private void VpisOsebVBazo ()
        {
            FirstName = NameTextBox.Text;
            LastName = SurnameTextBox.Text;
            HomeAdress = HomeAddressTextBox.Text;
            Post = Convert.ToInt32(PostTextBox.Text);
            City = CityTextBox.Text;
            PhoneNumber = Convert.ToInt32(PhoneNumberTextBox.Text);
            eMailAddress = eMailTextBox.Text;
            Oseba oseba = new Oseba(PhoneBook_id, UserID, FirstName, LastName, HomeAdress, Post, City, PhoneNumber, eMailAddress);

            switch(action)
            {
                case 1: 
                    // stavek za klic insert funkcije baze
                    break;
                case 2:
                    // stavek za klic update funkcije baze
                    break;
            }
        }
    }
}
