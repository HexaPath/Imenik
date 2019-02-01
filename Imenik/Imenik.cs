using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Magic;

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
                    SelectPhoneBookComboBox.Text = new Magic(reader.GetString(1));
                }
                com.Dispose();
                reader.Close();
            }
        }
    }
}
