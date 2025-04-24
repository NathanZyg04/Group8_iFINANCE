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
using iFINANCE.FinacialReports;

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


            // if the admin is null or the logged in user is a NonAdminUser, set admin only options to not visible
            if(admin == null)
            {
                editUsersToolStripMenuItem1.Visible = false;
                addUsersAdminOnlyToolStripMenuItem.Visible = false;

                // set the windows title text to welcome User
                this.Text = $"Group 8 iFinance | Welcome {user.name}";

            }

            if(admin != null)
            {
                this.Text = $"Group 8 iFinance | Weclome {admin.name}";
            }
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
            // send the current user in
            ChartOfAccountsForm masterAccounts = new ChartOfAccountsForm(user);
            masterAccounts.ShowDialog();
        }

        //private void ChangePasswordMenuItem_Click(object sender, EventArgs e)
        //{
        //    // create a new form and pass the current user or admin into it
        //    ChangePasswordForm passwordForm = new ChangePasswordForm(user,admin);
        //    passwordForm.ShowDialog();
        //}

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
                // pass the ID of the addmin to the form
                AddUserForm adduserForm = new AddUserForm(admin.ID);
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
            ChangePasswordForm passwordForm = new ChangePasswordForm(user,admin);

          

            passwordForm.ShowDialog();
            // after changing password log the user out and have them log back in

            this.Hide();

            LoginWindow newLogin = new LoginWindow();
            newLogin.ShowDialog();
            this.Close();


        }

        // Logout tool menu
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginWindow newLogin = new LoginWindow();
            newLogin.ShowDialog();
            this.Close();
        }
        //---------------------------------------------EXPIREMENTAL STUFF FOR FINANCIAL REPORTS-----------------------------------

        private void financialReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a context menu for financial reports
            ContextMenuStrip financialReportsMenu = new ContextMenuStrip();

            // Add options for each financial report
            financialReportsMenu.Items.Add("Trial Balance", null, (s, args) => GenerateTrialBalance());
            financialReportsMenu.Items.Add("Profit and Loss Statement", null, (s, args) => GenerateProfitAndLoss());
            financialReportsMenu.Items.Add("Balance Sheet", null, (s, args) => GenerateBalanceSheet());
            financialReportsMenu.Items.Add("Cash Flow Statement", null, (s, args) => GenerateCashFlowStatement());

            // Show the context menu at the mouse position
            financialReportsMenu.Show(Cursor.Position);
        }

        private void GenerateTrialBalance()
        {
            if (user == null)
            {
                MessageBox.Show("You must be logged in as a non-admin user to access this feature.");
                return;
            }

            // Open the TrialBalanceForm and pass the NonAdminUserId
            TrialBalanceForm trialBalanceForm = new TrialBalanceForm(user.ID);
            trialBalanceForm.MdiParent = this; //Set the parent form for MDI
            trialBalanceForm.Show();
        }


        private void GenerateProfitAndLoss()
        {
            // Logic to generate and display the Profit and Loss statement
            MessageBox.Show("Generating Profit and Loss statement...");
            // TODO: Implement the actual logic to fetch and display the Profit and Loss statement
        }

        private void GenerateBalanceSheet()
        {
            // Logic to generate and display the Balance Sheet
            MessageBox.Show("Generating Balance Sheet...");
            // TODO: Implement the actual logic to fetch and display the Balance Sheet
        }

        private void GenerateCashFlowStatement()
        {
            // Logic to generate and display the Cash Flow statement
            MessageBox.Show("Generating Cash Flow statement...");
            // TODO: Implement the actual logic to fetch and display the Cash Flow statement
        }

    }
}
