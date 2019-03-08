using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Imenik
{
    public partial class ImenikForm : Form
    {
        public ImenikForm()
        {
            InitializeComponent();
        }
        
        private SQLiteConnection con;

        private void SelectPhoneBookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            }
        } 
    }
}
