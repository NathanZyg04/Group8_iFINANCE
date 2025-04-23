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
        private Administrator admin;
        private ChangePasswordController controller;
        private iFINANCEModel systemModel = new iFINANCEModel();

       

        public ChangePasswordForm(NonAdminUser user, Administrator admin)
        {
            this.user = user;
            this.admin = admin;
            controller = new ChangePasswordController();

           
            InitializeComponent();

            this.Load += new System.EventHandler(controller.ChangePasswordController_Load);
            this.changeButton.Click += new System.EventHandler(controller.changeButton_Click);

        }

        public string getNewPasswordTextBox()
        {
            return newPasswordTextBox.Text;
        }

        public string getConfirmPasswordTextBox()
        {
            return confirmPasswordTextBox.Text;
        }

        // getters for the admin / nonadmin users
        public NonAdminUser getUser()
        {
            return user;
        }

        public Administrator getAdmin()
        {
            return admin;
        }
    }
}
