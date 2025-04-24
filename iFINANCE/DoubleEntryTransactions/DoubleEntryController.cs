using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE.DoubleEntryTransactions
{
    internal class DoubleEntryController
    {
        private readonly iFINANCEModel systemModel;
        private readonly DoubleEntryForm view;
        private int currentUserId;
        private int currentTransactionId;

        public DoubleEntryController(DoubleEntryForm view, int userId, int transactionId = 0)
        {
            this.view = view;
            this.systemModel = new iFINANCEModel();
            this.currentUserId = userId;
            this.currentTransactionId = transactionId;
            LoadAccounts();
            LoadTransactionLines();
        }

        public void LoadAccounts()
        {
            var creditAccounts = systemModel.MasterAccounts.Where(u => u.NonAdminUser_ID == currentUserId).Where(ma => ma.Group.AccountCategory.type == "Credit").ToList();
            view.SetCreditAccountComboBox(creditAccounts);
            var debitAccounts = systemModel.MasterAccounts.Where(u => u.NonAdminUser_ID == currentUserId).Where(ma => ma.Group.AccountCategory.type == "Debit").ToList();
            view.SetDebitAccountComboBox(debitAccounts);
            
        }

        public void LoadTransactionLines()
        {
            if (currentTransactionId == 0)
            {
                view.ClearTransactionLines();
                return;
            }

            var transaction = systemModel.Transactions.Find(currentTransactionId);
            if (transaction != null)
            {
                view.SetDescription(transaction.description);
                view.SetTransactionDate(transaction.date);
                view.SetTransactionNumber(transaction.ID.ToString()); //Set the transaction number
            }

            var lines = systemModel.TransactionLines
                .Where(tl => tl.Transaction.ID == currentTransactionId)
                .ToList();

            view.SetTransactionLines(lines);

            if (lines.Any())
            {
                var firstLine = lines.First();
                view.SetComment(firstLine.comment);
                view.SetAmount((firstLine.debitedAmount > 0 ? firstLine.debitedAmount : firstLine.creditedAmount).ToString("F2"));
                view.SetDebitAccount(firstLine.MasterAccounts.ID);
                view.SetCreditAccount(firstLine.MasterAccounts1.ID);
            }
        }

        private void UpdateMasterAccountsByTransactionLines(int transactionId)
        {
            //Fetch the transaction lines for the given transaction ID
            var transactionLines = systemModel.TransactionLines
                .Where(tl => tl.Transaction.ID == transactionId)
                .ToList();

            foreach (var line in transactionLines)
            {
                //Log the TransactionLine ID for debugging
                //Console.WriteLine($"Processing TransactionLine ID: {line.ID}");

                // Update the debit account's closing amount
                if (line.MasterAccounts != null && line.debitedAmount > 0)
                {
                    //Console.WriteLine($"Updating Debit Account for TransactionLine ID: {line.ID}");
                    UpdateMasterAccountClosingAmount(line.MasterAccounts.ID, line.debitedAmount, isDebit: true);
                }

                // Update the credit account's closing amount
                if (line.MasterAccounts != null && line.creditedAmount > 0)
                {
                    //Console.WriteLine($"Updating Credit Account for TransactionLine ID: {line.ID}");
                    UpdateMasterAccountClosingAmount(line.MasterAccounts.ID, line.creditedAmount, isDebit: false);
                }
            }
        }




        private void UpdateMasterAccountClosingAmount(int accountId, double amount, bool isDebit)
        {
            var account = systemModel.MasterAccounts.Find(accountId);
            if (account == null)
            {
                Console.WriteLine($"Account ID {accountId} not found.");
                return;
            }

            //Console.WriteLine($"Before Update: Account ID: {accountId}, Closing Amount: {account.closingAmount}");

            // Determine the effect based on the account's category type
            string accountName = account.Group.AccountCategory.name;
            //Console.WriteLine($"Account Name: {accountName}");

            if (isDebit)
            {
                if (accountName == "Assets" || accountName == "Expenses")
                {
                    account.closingAmount += amount; // Increase
                    //Console.WriteLine($"Assets or Expenses increased by {amount}");
                }
                else if (accountName == "Liabilities" || accountName == "Income")
                {
                    account.closingAmount -= amount; // Decrease
                    //Console.WriteLine($"Liabilities or Income decreased by {amount}");
                }
            }
            else // Credit
            {
                if (accountName == "Assets" || accountName == "Expenses")
                {
                    account.closingAmount -= amount; // Decrease
                    Console.WriteLine($"Assets or Expenses decreased by {amount}");
                }
                else if (accountName == "Liabilities" || accountName == "Income")
                {
                    account.closingAmount += amount; // Increase
                    //Console.WriteLine($"Liabilities or Income increased by {amount}");
                }
            }

            //Console.WriteLine($"After Update: Account ID: {accountId}, Closing Amount: {account.closingAmount}");

            systemModel.SaveChanges();
            //Console.WriteLine("Changes saved to the database.");
        }



        public void SaveTransaction()
{
    if (!double.TryParse(view.GetAmount(), out double amount))
    {
        view.ShowMessage("Please enter a valid amount.");
        return;
    }

    int debitAccountId = view.GetDebitAccountId();
    int creditAccountId = view.GetCreditAccountId();

    if (debitAccountId == creditAccountId)
    {
        view.ShowMessage("Debit and Credit accounts must be different.");
        return;
    }

    iFINANCE.Transaction transaction;
    if (currentTransactionId == 0)
    {
        transaction = new iFINANCE.Transaction
        {
            date = view.GetTransactionDate(),
            description = view.GetDescription(),
            NonAdminUser = systemModel.NonAdminUsers.Find(currentUserId)
        };
        systemModel.Transactions.Add(transaction);
    }
    else
    {
        transaction = systemModel.Transactions.Find(currentTransactionId);
        if (transaction == null)
        {
            view.ShowMessage("Transaction not found.");
            return;
        }
        transaction.date = view.GetTransactionDate();
        transaction.description = view.GetDescription();

        // Remove the existing transaction lines
        var existingLines = systemModel.TransactionLines.Where(tl => tl.Transaction.ID == currentTransactionId).ToList();
        foreach (var line in existingLines)
        {
            systemModel.TransactionLines.Remove(line);
        }
    }

    systemModel.SaveChanges();

    // Add new transaction lines
    var debitAccount = systemModel.MasterAccounts.Find(debitAccountId);
    var creditAccount = systemModel.MasterAccounts.Find(creditAccountId);

    if (debitAccount == null || creditAccount == null)
    {
        view.ShowMessage("One or both accounts not found.");
        return;
    }

    var debitLine = new iFINANCE.TransactionLine
    {
        debitedAmount = amount,
        creditedAmount = 0,
        comment = view.GetComment(),
        MasterAccounts = debitAccount,
        MasterAccounts1 = creditAccount,
        Transaction = transaction
    };

    var creditLine = new iFINANCE.TransactionLine
    {
        debitedAmount = 0,
        creditedAmount = amount,
        comment = view.GetComment(),
        MasterAccounts = creditAccount,
        MasterAccounts1 = debitAccount,
        Transaction = transaction
    };

    systemModel.TransactionLines.Add(debitLine);
    systemModel.TransactionLines.Add(creditLine);
    systemModel.SaveChanges();

    // Apply the effects of the new transaction lines on MasterAccounts
    UpdateMasterAccountsByTransactionLines(transaction.ID);

    view.ShowMessage("Transaction saved successfully.");
    ClearForm();
    LoadTransactionLines();
}



        public void UpdateTransaction()
        {
            using (var selectTransactionForm = new SelectTransactionForm(currentUserId))
            {
                if (selectTransactionForm.ShowDialog() == DialogResult.OK)
                {
                    currentTransactionId = selectTransactionForm.SelectedTransactionId;
                    LoadTransactionLines();
                }
            }
        }

        public void DeleteTransaction()
        {
            using (var selectTransactionForm = new SelectTransactionForm(currentUserId))
            {
                if (selectTransactionForm.ShowDialog() == DialogResult.OK)
                {
                    currentTransactionId = selectTransactionForm.SelectedTransactionId;

                    var transaction = systemModel.Transactions.Find(currentTransactionId);
                    if (transaction == null)
                    {
                        view.ShowMessage("Transaction not found.");
                        return;
                    }

                    var transactionLines = systemModel.TransactionLines.Where(tl => tl.Transaction.ID == currentTransactionId).ToList();
                    foreach (var line in transactionLines)
                    {
                        systemModel.TransactionLines.Remove(line);
                    }

                    systemModel.Transactions.Remove(transaction);
                    systemModel.SaveChanges();

                    view.ShowMessage("Transaction deleted successfully.");
                    ClearForm();
                    LoadTransactionLines();
                }
            }
        }

        public void NewTransaction()
        {
            ClearForm();
        }

        private void ClearForm()
        {
            currentTransactionId = 0;
            view.ClearForm();
        }
        public iFINANCE.Transaction GetTransactionById(int transactionId)
        {
            //Implementation to get transaction by ID
            return systemModel.Transactions.FirstOrDefault(t => t.ID == transactionId);
        }
    }
}

