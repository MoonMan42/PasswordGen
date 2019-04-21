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
        private List<PasswordModel> passwordList = new List<PasswordModel>();
        private List<PasswordModel> displayList; // resizable list for the user to choose how many to display at a time

        Random rand = new Random();

        public PasswordGen()
        {
            InitializeComponent();
            LoadPasswordList();
        }

        private void LoadPasswordList()
        {
            displayList = new List<PasswordModel>(); // reset list every time refreshed
            passwordList = SQLiteDataAccess.LoadPasswords();

            for (int i = 0; i < 3; i++)
            {
                displayList.Add(passwordList[rand.Next(passwordList.Count)]);
            }
            WireUpPasswordList();
        }

        private void WireUpPasswordList()
        {
            passwordGenListBox.DataSource = null;
            passwordGenListBox.DataSource = displayList;
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
