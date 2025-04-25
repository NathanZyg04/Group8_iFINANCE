using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iFINANCE.FinacialReports
{
    public partial class TrialBalanceForm : Form
    {
        private readonly TrialBalanceController controller;
        private readonly int nonAdminUserId; // Store the NonAdminUserId

        public TrialBalanceForm(int nonAdminUserId)
        {
            InitializeComponent();
            this.nonAdminUserId = nonAdminUserId; // Initialize NonAdminUserId
            controller = new TrialBalanceController(this); // Initialize the controller and pass the form (View) to it
        }

        private void TrialBalanceForm_Load(object sender, EventArgs e)
        {
            // Call the controller to load the Trial Balance data for the specific NonAdminUser
            controller.LoadTrialBalanceForUser(nonAdminUserId);
        }

        // Method to display the Trial Balance data in the DataGridView
        public void DisplayTrialBalance(List<TrialBalanceRow> trialBalanceRows, double totalDebit, double totalCredit)
        {
            // Clear existing rows
            trialBalanceDataGridView.Rows.Clear();

            // Populate the DataGridView with Trial Balance rows
            foreach (var row in trialBalanceRows)
            {
                trialBalanceDataGridView.Rows.Add(row.AccountName, row.DebitAmount, row.CreditAmount);
            }

            // Display totals
            totalDebitTextBox.Text = totalDebit.ToString("C");
            totalCreditTextBox.Text = totalCredit.ToString("C");

            // Ensure totals match
            if (totalDebit != totalCredit)
            {
                MessageBox.Show("Warning: Debit and Credit totals do not match!", "Trial Balance Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
