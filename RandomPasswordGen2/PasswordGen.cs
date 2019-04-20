using PasswordLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPasswordGen2
{
    public partial class PasswordGen : Form
    {
        List<PasswordModel> passwordList = new List<PasswordModel>();

        public PasswordGen()
        {
            InitializeComponent();
            LoadPasswordList();
        }

        private void LoadPasswordList()
        {
            passwordList = SQLiteDataAccess.LoadPasswords();
            WireUpPasswordList();
        }

        private void WireUpPasswordList()
        {
            passwordGenListBox.DataSource = null;
            passwordGenListBox.DataSource = passwordList;
            passwordGenListBox.DisplayMember = "DisplayPassword";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // don't add or delete or you'll break it
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadPasswordList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PasswordModel p = new PasswordModel();

            p.Password = addTextBox.Text;

            SQLiteDataAccess.SavePassword(p);

            addTextBox.Text = ""; // clear text field

            LoadPasswordList(); 
        }
    }
}
