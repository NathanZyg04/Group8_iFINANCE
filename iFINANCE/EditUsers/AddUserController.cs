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
        private readonly iFINANCEModel systemModel;  // set the link to the model


        public AddUserController()
        {
            this.systemModel = new iFINANCEModel();
        }

        public void AddUserController_Load(object sender, EventArgs e)
        {
            _view = (AddUserForm)sender;
            
        }



        public void createUserButton_Click(object sender, EventArgs e)
        {
            // get the admin from this instance of the systemModel
            int adminID = _view.getAdmin();

            
            //Administrator admin = systemModel.Administrators.FirstOrDefault(a => a.ID == adminID);
            //MessageBox.Show($"{admin.ID}");

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
                iFINANCE.UserPassword userPassword = new iFINANCE.UserPassword
                {
                    userName = username,
                    // encrypt the password
                    encryptedPassword = PasswordHasher.Hash(password),
                    passwordExpiryTime = 1,
                    userAccountExpiryDate = System.DateTime.Now
                };


                systemModel.UserPasswords.Add(userPassword);

                iFINANCE.NonAdminUser newUser = new iFINANCE.NonAdminUser
                {
                    name = name,
                    address = address,
                    email = email,
                    UserPassword = userPassword,
                    Administrator = systemModel.Administrators.Find(adminID)
                };

                
                systemModel.NonAdminUsers.Add(newUser);
                systemModel.SaveChanges();

                MessageBox.Show($"User {name} created!");

            }
            else
            {
                MessageBox.Show("Error, Passwords do not match");
            }

        }

        public void createAdminButton_Click(Object sender, EventArgs e)
        {
            // get the admin from this instance of the systemModel
            int adminID = _view.getAdmin();


            //Administrator admin = systemModel.Administrators.FirstOrDefault(a => a.ID == adminID);
            //MessageBox.Show($"{admin.ID}");

            // get the textbox strings
            string name = _view.getNameTextBox();
            string address = _view.getPasswordTextBox();
            string email = _view.getEmailTextBox();
            string username = _view.getUsernameTextBox();
            string password = _view.getPasswordTextBox();
            string confirmPassword = _view.getConfirmPasswordTextBox();

            // Expiry time needs to be set to something real

            if (password.Equals(confirmPassword))
            {
                iFINANCE.UserPassword userPassword = new iFINANCE.UserPassword
                {
                    userName = username,
                    // encrypt the password
                    encryptedPassword = PasswordHasher.Hash(password),
                    passwordExpiryTime = 1,
                    userAccountExpiryDate = System.DateTime.Now
                };


                systemModel.UserPasswords.Add(userPassword);

                iFINANCE.Administrator newUser = new iFINANCE.Administrator
                {
                    name = name,
                    dateHired = System.DateTime.Today,
                    UserPassword = userPassword,
                };


                systemModel.Administrators.Add(newUser);
                systemModel.SaveChanges();

                MessageBox.Show($"Admin {name} created!");

            }
            else
            {
                MessageBox.Show("Error, Passwords do not match");
            }
        }

    }

    
}
