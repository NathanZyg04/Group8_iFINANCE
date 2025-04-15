using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace iFINANCE
{
    public partial class ChangePasswordForm : Form
    {
        private NonAdminUser user;
        private iFINANCEModel systemModel = new iFINANCEModel();
        public ChangePasswordForm(NonAdminUser user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // check that the new passwords equal eachother
            if(newPassword.Equals(confirmPassword))
            {
                // update user password table
                

                var dbUser = systemModel.NonAdminUsers.Include(u => u.UserPassword).FirstOrDefault(u => u.ID == user.ID);

                if(dbUser != null)
                {
                    dbUser.UserPassword.encryptedPassword = newPassword;
                    systemModel.SaveChanges();

                    MessageBox.Show("Password successfully updated.");
                    this.DialogResult = DialogResult.OK;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Error! Passwords do not match!");
            }
        }
    }
}
