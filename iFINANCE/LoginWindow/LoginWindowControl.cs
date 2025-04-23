using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace iFINANCE
{
    class LoginWindowControl
    {
        private static LoginWindow _view;
        private iFINANCEModel systemModel = new iFINANCEModel();  // set the link to the model


        public void LoginWindowForm_Load(object sender, EventArgs e)
        {

            _view = (LoginWindow)sender;

        }

        public void LoginButton_Click(object sender, EventArgs e)
        {
            string username = _view.getUsernameText();
            string password = _view.getPasswordText();


            // get the hashed password
            string hashedPass = PasswordHasher.Hash(password);

            NonAdminUser currentUser = null;

            
            var nonAdminUser = systemModel.NonAdminUsers.Include(u => u.UserPassword)
                                                        .FirstOrDefault(u => u.UserPassword.userName == username &&
                                                                        u.UserPassword.encryptedPassword == hashedPass);

           
                    
            if(nonAdminUser != null)
            {

               
                // Hide login form
                _view.Hide();
                
                
                // Show main form and pass the user
                MainForm mainForm = new MainForm(nonAdminUser, null);
                mainForm.FormClosed += (s, args) => _view.Close(); // Close app when main form closes
                mainForm.Show();
                return;
            }

            var adminUser = systemModel.Administrators.Include(u => u.UserPassword)
                                                     .FirstOrDefault(u => u.UserPassword.userName == username &&
                                                                       u.UserPassword.encryptedPassword == hashedPass);

            if (adminUser != null)
            {
              

                // Hide login form
                _view.Hide();
               

                // Show main form and pass the user
                MainForm mainForm = new MainForm(null, adminUser);
                mainForm.FormClosed += (s, args) => _view.Close(); // Close app when main form closes
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }


    }
}
