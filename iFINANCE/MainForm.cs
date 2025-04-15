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
    public partial class MainForm : Form
    {
        private NonAdminUser user;
        private Administrator admin;
        public MainForm(NonAdminUser user, Administrator admin)
        {
            this.admin = admin;
            this.user = user;
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutMe = new about();
            // Display the new about form a dialog.
            aboutMe.ShowDialog();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cascade all MDI child windows.
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tile all child forms horizontally.
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tile all child forms vertically.
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void manageAccountGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsGroupsForm groups = new AccountsGroupsForm();
            groups.ShowDialog(); 
        }

        private void function2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartOfAccountsForm masterAccounts = new ChartOfAccountsForm();
            masterAccounts.ShowDialog();
        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e)
        {
            // create a new form and pass the current user into it
            ChangePasswordForm passwordForm = new ChangePasswordForm(user);
            passwordForm.ShowDialog();
        }

        // Edit users options
        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(admin == null)
            {
                MessageBox.Show("You do not have Permission to edit users!");
                
            }
            else
            {
                MessageBox.Show("You are an admin!");
                EditUsersForm editForm = new EditUsersForm();
                editForm.ShowDialog();
            }
        }
    }
}
