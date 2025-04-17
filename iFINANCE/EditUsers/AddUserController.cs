using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iFINANCE.EditUsers;

namespace iFINANCE
{
    class AddUserController
    {
        private static AddUserForm _view;
        private iFINANCEModel systemModel = new iFINANCEModel();  // set the link to the model

        public void AddUserController_Load(object sender, EventArgs e)
        {
            _view = (AddUserForm)sender;
        }



        public void createUserButton_Click(object sender, EventArgs e)
        {
            // get the admin from this instance of the systemModel
            Administrator originalAdmin = _view.getAdmin();

            
            Administrator admin = systemModel.Administrators.FirstOrDefault(a => a.ID == originalAdmin.ID);

            // get the textbox strings
            string name = _view.getNameTextBox();
            string address = _view.getPasswordTextBox();
            string email = _view.getEmailTextBox();
            string username = _view.getUsernameTextBox();
            string password = _view.getPasswordTextBox();
            string confirmPassword = _view.getConfirmPasswordTextBox();

            // Expiry time needs to be set to something real

            if(password.Equals(confirmPassword))
            {
                var userPassword = new UserPassword
                {
                    userName = username,
                    encryptedPassword = password,
                    passwordExpiryTime = 1,
                    userAccountExpiryDate = System.DateTime.Now
                };

               

                var newUser = new NonAdminUser
                {
                    name = name,
                    address = address,
                    email = email,
                    UserPassword = userPassword,
                    Administrator = admin
                };

                systemModel.NonAdminUsers.Add(newUser);
                systemModel.SaveChanges();

                MessageBox.Show("New user created!");

            }
            else
            {
                MessageBox.Show("Error, Passwords do not match");
            }








        }

    }

    
}
