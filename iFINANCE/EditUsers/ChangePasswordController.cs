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

                var user = _view.getUser();


                var dbUser = systemModel.NonAdminUsers.Include(u => u.UserPassword).FirstOrDefault(u => u.ID == user.ID);

                if (dbUser != null)
                {
                    dbUser.UserPassword.encryptedPassword = newPassword;
                    systemModel.SaveChanges();

                    MessageBox.Show("Password successfully updated.");
                    //this.DialogResult = DialogResult.OK;
                }

                _view.Close();
            }
            else
            {
                MessageBox.Show("Error! Passwords do not match!");
            }
        }
    }
}
