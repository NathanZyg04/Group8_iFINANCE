using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    public partial class EditUsersForm : Form
    {
        private iFINANCEModel systemModel = new iFINANCEModel();
        public EditUsersForm()
        {
            InitializeComponent();

            // Select the nonadmin users from database
            var users = systemModel.NonAdminUsers
                               .Select(u => new
                               {
                                   u.ID,
                                   u.name,
                                   u.email
                               })
                               .ToList();

            // format the users for the list, displat their name and email address
            var formattedUsers = users.Select(u => new
            {
                u.ID,
                Display = $"{u.name} ({u.email})"
            }).ToList();

            // update list box to displat user info
            userListBox.DataSource = formattedUsers;
            userListBox.DisplayMember = "Display";
            userListBox.ValueMember = "ID";

        }

        // logic for when you click on a user from list
        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Skip if nothing is selected or value isn't an int
            if (userListBox.SelectedValue == null || !(userListBox.SelectedValue is int userID))
                return;

            
           

                // get the user from the database based off the userID from list box
                NonAdminUser user = systemModel.NonAdminUsers.FirstOrDefault(u => u.ID == userID);

                // set the values of the text box to the current user's values
                nameTextBox.Text = user.name;
                emailTextBox.Text = user.email;
                addressTextBox.Text = user.address;
                usernameTextBox.Text = user.UserPassword.userName;
            
        }

        // edit user button
        private void editUserButton_Click(object sender, EventArgs e)
        {
            // get the new strings from the text box
            string newName = nameTextBox.Text;
            string newEmail = emailTextBox.Text;
            string newAddress = addressTextBox.Text;
            string newUsername = usernameTextBox.Text;

            // check if there is a selected user
            if (userListBox.SelectedValue is int userID)
            {
                // get the user 
                NonAdminUser user = systemModel.NonAdminUsers.FirstOrDefault(u => u.ID == userID);

                // update the user's info
                user.name = newName;
                user.email = newEmail;
                user.address = newAddress;
                user.UserPassword.userName = newUsername;

                // save changes to DB
                systemModel.SaveChanges();

                MessageBox.Show("User updated!");
            }
            else
            {
                MessageBox.Show("No user selected!");
            }

        }
    }
}
