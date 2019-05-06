using PasswordLibrary2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RandomPasswordGen2
{
    public partial class PasswordGen : Form
    {
        private List<PasswordModel> passwordList = new List<PasswordModel>();

        Random rand = new Random();

        public PasswordGen()
        {
            InitializeComponent();
            LoadPasswordList();
        }

        private void LoadPasswordList()
        {
            passwordList = SQLiteDataAccess.LoadPasswords();


            // swap out a special character ("*") with a random number
            foreach (var p in passwordList)
            {
                int randNum = rand.Next(10, 100);


                p.Password = p.Password.Replace("*", $"{randNum}");
            }

            WireUpPasswordList();
        }

        private void WireUpPasswordList()
        {
            passwordGenListBox.DataSource = null;
            passwordGenListBox.DataSource = passwordList;
            passwordGenListBox.DisplayMember = "DisplayPassword";
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadPasswordList();

        }

        // add password action
        private void addTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPassword();
            }
        }

        
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPassword();
        }

        // delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // find the password in the passwordlist
            string temp = passwordGenListBox.GetItemText(passwordGenListBox.SelectedItem);

            PasswordModel p = passwordList.Find(x => x.Password == temp);

            SQLiteDataAccess.RemovePassword(p);

            // reload the list
            LoadPasswordList();
        }

        // copy button 
        private void copyButton_Click(object sender, EventArgs e)
        {
            string temp = passwordGenListBox.GetItemText(passwordGenListBox.SelectedItem);
            try
            {
                Clipboard.SetText($"{temp}");
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        private void passwordGenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get currently selected item in the list box
            string curItem = passwordGenListBox.GetItemText(passwordGenListBox.SelectedItem);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPasswordList();
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete the database and start over?",
                "Are you Sure?", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    SQLiteDataAccess.DeleteAllPasswords();                    
                    LoadPasswordList();// Refresh list
                    break;
                case DialogResult.No:
                    break;
            }            
        }



        // add new field
        private void AddPassword()
        {
            PasswordModel p = new PasswordModel();

            p.Password = addTextBox.Text;

            SQLiteDataAccess.SavePassword(p);

            addTextBox.Text = ""; // clear text field

            LoadPasswordList();
        }

        private void refreshToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadPasswordList();
        }

        private void deleteAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all entries.", "Are you sure", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteDataAccess.DeleteAllPasswords();
                LoadPasswordList(); // refresh list
            } else
            {
                // do nothing
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
