using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    internal class EditUsersController
    {
        private static EditUsersForm _view;
        private iFINANCEModel systemModel = new iFINANCEModel();
        private NonAdminUser currentSelectedUser;

        public void EditUsersController_Load(object sender, EventArgs e)
        {
            _view = (EditUsersForm)sender;

            // set the current selected user to the first one in database
            currentSelectedUser = systemModel.NonAdminUsers.First();


            
            updateUserList();


        }
            
        // updates the user list box
        public void updateUserList()
        {
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
            //userListBox.DataSource = formattedUsers;
            //userListBox.DisplayMember = "Display";
            //userListBox.ValueMember = "ID";

            _view.SetUserListBoxDataSource(formattedUsers, "Display", "ID");
        }

        public void editUserButton_Click(object sender, EventArgs e)
        {
            // get the new strings from the text box
            string newName = _view.getNameTextBox();
            string newEmail = _view.getEmailTextBox();
            string newAddress = _view.getAddressTextBox();
            string newUsername = _view.getUsernameTextBox();

            // check if there is a selected user
            if (_view.GetSelectedUserId() is int userID)
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


        public void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Skip if nothing is selected or value isn't an int
            if (_view.GetSelectedUserId() == null || !(_view.GetSelectedUserId() is int userID))
                return;


            // set the current selected User
            currentSelectedUser = systemModel.NonAdminUsers.FirstOrDefault(u => u.ID == userID);

            // get the user from the database based off the userID from list box
            NonAdminUser user = systemModel.NonAdminUsers.FirstOrDefault(u => u.ID == userID);

            // set the values of the text box to the current user's values
   

            _view.setUserTextBox(user.name, user.email, user.address, user.UserPassword.userName);

        }

        // deleting a user functionality
        public void deleteUserButton_Click(object sender, EventArgs e)
        {
            if(currentSelectedUser != null)
            {
                // Display a warning message box to confirm delete
                DialogResult result = MessageBox.Show($"Do you want to delete {currentSelectedUser.name}?","Warning",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                        );

                if (result == DialogResult.Yes)
                {
                    // remove user from database
                    systemModel.NonAdminUsers.Remove(currentSelectedUser);
                    systemModel.SaveChanges();

                    updateUserList();
                }


            }
            else
            {
                MessageBox.Show("No user selected!");
            }
        }
    }
}
