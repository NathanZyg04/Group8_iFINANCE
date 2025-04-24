using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE.EditUsers
{
    public partial class AddUserForm : Form
    {
        private AddUserController controller;
        private int adminID;
        private iFINANCEModel systemModel = new iFINANCEModel();
        public AddUserForm(int adminID)
        {
            this.adminID = adminID;
            controller = new AddUserController();

            InitializeComponent();

            // link up the form to the controller events for button clicks
            this.Load += new System.EventHandler(controller.AddUserController_Load);
            this.createUserButton.Click += new System.EventHandler(controller.createUserButton_Click);
            this.createAdminButton.Click += new System.EventHandler(controller.createAdminButton_Click);
        }



        // getter functions 
        public int getAdmin()
        {
            return adminID;
        }
        // getter function for the view's text box strings
        public string getNameTextBox()
        {
            return nameTextBox.Text;
        }

        public string getAddressTextBox()
        {
            return addressTextBox.Text;
        }

        public string getEmailTextBox()
        {
            return emailTextBox.Text;
        }

        public string getUsernameTextBox()
        {
            return usernameTextBox.Text;
        }

        public string getPasswordTextBox()
        {
            return passwordTextBox.Text;
        }

        public string getConfirmPasswordTextBox()
        {
            return confrimPasswordTextBox.Text;
        }
    }
}
