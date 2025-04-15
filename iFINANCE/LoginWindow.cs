using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    public partial class LoginWindow : Form
    {

        private iFINANCEModel systemModel = new iFINANCEModel();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            NonAdminUser currentUser = null;

            foreach (var user in systemModel.NonAdminUsers)
            {
                if (user.UserPassword.encryptedPassword.Equals(password) &&
                    user.UserPassword.userName.Equals(username))
                {
                    currentUser = user;
                    break;
                }
            }

            if (currentUser != null)
            {
                MessageBox.Show($"Welcome, {currentUser.name}!");

                // Hide login form
                this.Hide();

                // Show main form and pass the user
                MainForm mainForm = new MainForm(currentUser);
                mainForm.FormClosed += (s, args) => this.Close(); // Close app when main form closes
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

    }
}
