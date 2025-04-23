using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace iFINANCE
{
    class ChangePasswordController
    {

        private ChangePasswordForm _view;
        private iFINANCEModel systemModel = new iFINANCEModel();

      

        public void ChangePasswordController_Load(object sender, EventArgs e)
        {
            _view = (ChangePasswordForm)sender;
        }


        public void changeButton_Click(object sender, EventArgs e)
        {
            string newPassword = _view.getNewPasswordTextBox();
            string confirmPassword = _view.getConfirmPasswordTextBox();

            // check that the new passwords equal eachother
            if (newPassword.Equals(confirmPassword))
            {
                // update user password table


                // if the current user is a NonAdminUser
                var user = _view.getUser();

                if(user != null)
                {
                    var dbUser = systemModel.NonAdminUsers.Include(u => u.UserPassword).FirstOrDefault(u => u.ID == user.ID);

                    if (dbUser != null)
                    {
                        // set the new password to the newPassword (hashed)
                        dbUser.UserPassword.encryptedPassword = PasswordHasher.Hash(newPassword);
                        systemModel.SaveChanges();

                        // notify user that it worked
                        MessageBox.Show("Password successfully updated.");

                       
                        
                        _view.Close();
                        return;
                    }

                }

                // if the current User is an Admin
                var admin = _view.getAdmin();

                if(admin != null)
                {
                    var adminUser = systemModel.Administrators.Include(u => u.UserPassword).FirstOrDefault(u => u.ID == admin.ID);

                    if(adminUser != null)
                    {
                        adminUser.UserPassword.encryptedPassword = PasswordHasher.Hash(newPassword);
                        systemModel.SaveChanges();

                        // notify user that it worked
                        
                        MessageBox.Show("Password successfully updated.");


                        _view.Close();

                        return;
                        
                    }
                }

                MessageBox.Show("Something went wrong!");

            }
            else
            {
                MessageBox.Show("Error! Passwords do not match!");
            }
        }
    }
}
