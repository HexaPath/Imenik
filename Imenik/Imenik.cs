using System;
using System.Windows.Forms;
using System.Data; 
using System.Data.SQLite;
using BlackBox;

namespace Imenik
{
    public partial class ImenikForm : Form
    {
        public ImenikForm()
        {
            InitializeComponent();
            Dropdown();
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
        string PhoneNumber = "";

        int action = 0;

        /// <summary>
        /// IMENIK : možno je imeti več različnih imenikov.
        /// </summary>
        /// 
        
        
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
                    PhoneNumber = PhoneNumberTextBox.Text;
                }
                else { PhoneNumber = "000000000";}
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
                    //MessageBox.Show("ShowUp");
                    Database DodajOsebo = new Database();
                    if(DodajOsebo.AddOseba(newOseba2) == true)
                    {
                        Display();
                        //MessageBox.Show("Entery Successful!");
                    }
                    // stavek za klic insert funkcije baze
                    break;
                case 2:
                    Database UrediOsebo = new Database();
                    if(UrediOsebo.UpdateOseba(newOseba1) == true)
                    {
                        Display();
                        //MessageBox.Show("Edit Successful!");
                    }
                    // stavek za klic update funkcije baze
                    break;
                case 3:
                    Database izbrisOsebe = new Database();
                    if (izbrisOsebe.DeleteOseba(newOseba) == true)
                    {
                        Display();
                        //MessageBox.Show("Removal Successful!");
                    }
                    break;
                case 4:
                    Database DodajImenik = new Database();
                    if(DodajImenik.AddImenik(newImenik) == true)
                    {
                        Dropdown();
                        //MessageBox.Show("Entery Successful!");
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
            Display();
        }

        private void ImenikDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ImenikDataGrid.CurrentRow != null && ImenikDataGrid.CurrentRow.Index > -1)
                {
                    string ID = "";
                    ID = ImenikDataGrid.CurrentRow.Cells[0].Value != null ? ImenikDataGrid.CurrentRow.Cells[0].Value.ToString() : "";
                    NameTextBox.Text = ImenikDataGrid.CurrentRow.Cells[1].Value != null ? ImenikDataGrid.CurrentRow.Cells[1].Value.ToString() : "";
                    SurnameTextBox.Text = ImenikDataGrid.CurrentRow.Cells[2].Value != null ? ImenikDataGrid.CurrentRow.Cells[2].Value.ToString() : "";
                    HomeAddressTextBox.Text = ImenikDataGrid.CurrentRow.Cells[3].Value != null ? ImenikDataGrid.CurrentRow.Cells[3].Value.ToString() : "";
                    PostTextBox.Text = ImenikDataGrid.CurrentRow.Cells[4].Value != null ? ImenikDataGrid.CurrentRow.Cells[4].Value.ToString() : "";
                    CityTextBox.Text = ImenikDataGrid.CurrentRow.Cells[5].Value != null ? ImenikDataGrid.CurrentRow.Cells[5].Value.ToString() : "";
                    PhoneNumberTextBox.Text = ImenikDataGrid.CurrentRow.Cells[6].Value != null ? ImenikDataGrid.CurrentRow.Cells[6].Value.ToString() : "";
                    eMailTextBox.Text = ImenikDataGrid.CurrentRow.Cells[7].Value != null ? ImenikDataGrid.CurrentRow.Cells[7].Value.ToString() : ""; 
                    UserID = Convert.ToInt32(ID);
                }
            }
            catch (Exception ex) // If... if somethings goes wrong
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        void Display() //Refresh Function
        {
            SQLiteConnection con = new SQLiteConnection("datasource=Database.db");
            con.Open();
            DataTable table = new DataTable();
            SQLiteDataAdapter adptr = new SQLiteDataAdapter("SELECT * FROM  osebe WHERE PhoneBook_id = '"+ PhoneBook_id+"'", con);
            adptr.Fill(table);
            ImenikDataGrid.Rows.Clear();

            foreach (DataRow oseba in table.Rows)    //  Instant Output of Input :D
            {
                int x = ImenikDataGrid.Rows.Add();
                ImenikDataGrid.Rows[x].Cells[0].Value = oseba[0].ToString();
                ImenikDataGrid.Rows[x].Cells[1].Value = oseba[1].ToString();
                ImenikDataGrid.Rows[x].Cells[2].Value = oseba[2].ToString();
                ImenikDataGrid.Rows[x].Cells[3].Value = oseba[3].ToString();
                ImenikDataGrid.Rows[x].Cells[4].Value = oseba[4].ToString();
                ImenikDataGrid.Rows[x].Cells[5].Value = oseba[5].ToString();
                ImenikDataGrid.Rows[x].Cells[6].Value = oseba[6].ToString();
                ImenikDataGrid.Rows[x].Cells[7].Value = oseba[7].ToString();
            }
        }

        private void Dropdown()
        {
            SQLiteConnection con = new SQLiteConnection("datasource=Database.db");
            con.Open();
            using (SQLiteCommand com = new SQLiteCommand(con))
            { 
                com.CommandText = "SELECT id, Name FROM imeniki";//SQL STAVEK  
                SQLiteDataAdapter dAdapter = new SQLiteDataAdapter();
                DataTable data = new DataTable();
                dAdapter.SelectCommand = com;
                dAdapter.Fill(data);
                if(data !=null)
                {
                    if(data.Rows.Count > 0)
                    {
                        data.Columns.Add("Phonebook", typeof(string), "name");
                        SelectPhoneBookComboBox.DataSource = data;
                        SelectPhoneBookComboBox.ValueMember = "id";
                        SelectPhoneBookComboBox.DisplayMember = "Phonebook";
                        SelectPhoneBookComboBox.Enabled = true;
                    }
                    else if(data.Rows.Count <= 0)
                    {
                        SelectPhoneBookComboBox.Enabled = false;
                        SelectPhoneBookComboBox.Text = "Nothing to display";
                    }
                }
                com.Dispose();
                con.Close();
            }
            Display();
        }

        private void SelectPhoneBookComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Imeniki imenik = new Imeniki();
            PhoneBook = SelectPhoneBookComboBox.GetItemText(SelectPhoneBookComboBox.SelectedItem);
            PhoneBook_id = Convert.ToInt32(SelectPhoneBookComboBox.GetItemText(SelectPhoneBookComboBox.SelectedValue));
            imenik.PhoneBook = PhoneBook;
            Display();
        }
    }
    
}
