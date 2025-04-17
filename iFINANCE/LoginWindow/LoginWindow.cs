using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iFINANCE
{
    public partial class LoginWindow : Form
    {
        LoginWindowControl controller;
        private iFINANCEModel systemModel = new iFINANCEModel();
        public LoginWindow()
        {
            InitializeComponent();

            controller = new LoginWindowControl();
            this.Load += new System.EventHandler(controller.LoginWindowForm_Load);
            this.LoginButton.Click += new System.EventHandler(controller.LoginButton_Click);
        }

        public string getUsernameText()
        {
            return usernameTextBox.Text;
        }

        public string getPasswordText()
        {
            return passwordTextBox.Text;
        }

        

    }
}
