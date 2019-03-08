using System;
using System.Windows.Forms;

namespace Imenik
{
    public partial class ImenikForm : Form
    {
        public ImenikForm()
        {
            InitializeComponent();
        }
        
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
            // v bazo vpiše vse podatke osebe, v imenik, ki je trenutno izbran
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // v bazi posodobi podatke osebe
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // v bazi izbriše osebo
        }
    }
}
