using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    public partial class EditUsersForm : Form
    {
        private EditUsersController controller;
        private iFINANCEModel systemModel = new iFINANCEModel();
        public EditUsersForm()
        {
            InitializeComponent();

            controller = new EditUsersController();

            this.Load += new System.EventHandler(controller.EditUsersController_Load);
            this.userListBox.SelectedIndexChanged += new System.EventHandler(controller.userListBox_SelectedIndexChanged);
            this.editUserButton.Click += new System.EventHandler(controller.editUserButton_Click);

           

        }

        public void SetUserListBoxDataSource(object dataSource, string displayMember, string valueMember)
        {
            userListBox.DataSource = dataSource;
            userListBox.DisplayMember = displayMember;
            userListBox.ValueMember = valueMember;
        }

        public object GetSelectedUserId()
        {
            return userListBox.SelectedValue;
        }

        public void setUserTextBox(string name, string email, string address, string userName) 
        {
            nameTextBox.Text = name;
            emailTextBox.Text = email;
            addressTextBox.Text = address;
            usernameTextBox.Text = userName;
        }




        public string getNameTextBox()
        {
            return nameTextBox.Text;
        }

        public string getEmailTextBox()
        {
            return emailTextBox.Text;
        }

        public string getAddressTextBox()
        {
            return addressTextBox.Text;
        }

        public string getUsernameTextBox()
        {
            return usernameTextBox.Text;
        }


      
        
    }
}
