using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iFINANCE.FinacialReports
{
    internal class TrialBalanceController
    {
        private readonly iFINANCEModel systemModel;
        private readonly TrialBalanceForm view;

        public TrialBalanceController(TrialBalanceForm view)
        {
            this.view = view;
            this.systemModel = new iFINANCEModel(); // Use the existing database context
        }

        public void LoadTrialBalanceForUser(int nonAdminUserId)
        {
            try
            {
                // Fetch data for the Trial Balance for the specific NonAdminUser
                List<TrialBalanceRow> trialBalanceRows = GetTrialBalanceDataForUser(nonAdminUserId);

                // Calculate totals
                double totalDebit = trialBalanceRows.Sum(row => row.DebitAmount);
                double totalCredit = trialBalanceRows.Sum(row => row.CreditAmount);

                // Pass the data to the view for display
                view.DisplayTrialBalance(trialBalanceRows, totalDebit, totalCredit);
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show($"Error loading Trial Balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<TrialBalanceRow> GetTrialBalanceDataForUser(int nonAdminUserId)
        {
            // Query the database to fetch account balances for the specific NonAdminUser
            var trialBalanceRows = systemModel.MasterAccounts
                .Where(ma => ma.NonAdminUser_ID == nonAdminUserId) // Filter by NonAdminUserId
                .GroupJoin(
                    systemModel.TransactionLines,
                    ma => ma.ID,
                    tl => tl.MasterAccounts.ID,
                    (ma, tls) => new
                    {
                        AccountName = ma.name,
                        DebitAmount = tls.Sum(tl => (double?)tl.debitedAmount) ?? 0, // Cast to nullable double
                        CreditAmount = tls.Sum(tl => (double?)tl.creditedAmount) ?? 0 // Cast to nullable double
                    })
                .Select(result => new TrialBalanceRow
                {
                    AccountName = result.AccountName,
                    DebitAmount = result.DebitAmount,
                    CreditAmount = result.CreditAmount
                })
                .ToList();

            return trialBalanceRows;
        }

        public void RefreshTrialBalance(int nonAdminUserId)
        {
            // Clear the form and reload the Trial Balance data for the specific NonAdminUser
            view.DisplayTrialBalance(new List<TrialBalanceRow>(), 0, 0);
            LoadTrialBalanceForUser(nonAdminUserId);
        }
    }

    public class TrialBalanceRow
    {
        public string AccountName { get; set; }
        public double DebitAmount { get; set; }
        public double CreditAmount { get; set; }
    }
}
