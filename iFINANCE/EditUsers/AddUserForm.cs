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
        private Administrator admin;
        private iFINANCEModel systemModel = new iFINANCEModel();
        public AddUserForm(Administrator admin)
        {
            this.admin = admin;
            controller = new AddUserController();

            InitializeComponent();

            this.Load += new System.EventHandler(controller.AddUserController_Load);
            this.createUserButton.Click += new System.EventHandler(controller.createUserButton_Click);
        }



        public Administrator getAdmin()
        {
            return admin;
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
