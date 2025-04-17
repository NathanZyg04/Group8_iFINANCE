using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iFINANCE.EditUsers;

namespace iFINANCE
{
    public partial class MainForm : Form
    {
        private NonAdminUser user;
        private Administrator admin;
        private DoubleEntryForm doubleEntryFormInstance;
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
                
                EditUsersForm editForm = new EditUsersForm();
                editForm.ShowDialog();
            }
        }

        private void DoubleEntryToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            //Open the DoubleEntryForm for double entry transactions
            if (user == null)
            {
                MessageBox.Show("You must be logged in as a non-admin user to access this feature.");
                return;
            }

            if (doubleEntryFormInstance == null || doubleEntryFormInstance.IsDisposed)
            {
                doubleEntryFormInstance = new DoubleEntryForm(user.ID);
                doubleEntryFormInstance.MdiParent = this;
                doubleEntryFormInstance.FormClosed += (s, args) => doubleEntryFormInstance = null;
                doubleEntryFormInstance.Show();
            }
            else
            {
                doubleEntryFormInstance.BringToFront();
            }
        }

        private void addUsersAdminOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(admin != null)
            {
                AddUserForm adduserForm = new AddUserForm(admin);
                adduserForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have Permission to add users!");
            }
            
        }


        
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new form and pass the current user into it
            ChangePasswordForm passwordForm = new ChangePasswordForm(user);
            passwordForm.ShowDialog();
        }
    }
}
