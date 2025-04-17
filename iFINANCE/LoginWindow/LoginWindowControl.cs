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

            var nonAdminUser = systemModel.NonAdminUsers.Include(u => u.UserPassword)
                                                        .FirstOrDefault(u => u.UserPassword.userName == username &&
                                                                        u.UserPassword.encryptedPassword == password);

           
                    
            if(nonAdminUser != null)
            {
               

                // Hide login form
                _view.Hide();
                

                // Show main form and pass the user
                MainForm mainForm = new MainForm(currentUser, null);
                mainForm.FormClosed += (s, args) => _view.Close(); // Close app when main form closes
                mainForm.Show();
            }

            var adminUser = systemModel.Administrators.Include(u => u.UserPassword)
                                                     .FirstOrDefault(u => u.UserPassword.userName == username &&
                                                                       u.UserPassword.encryptedPassword == password);

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
