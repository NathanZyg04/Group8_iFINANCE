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

                var existingLines = systemModel.TransactionLines.Where(tl => tl.Transaction.ID == currentTransactionId).ToList();
                foreach (var line in existingLines)
                {
                    systemModel.TransactionLines.Remove(line);
                }
            }

            systemModel.SaveChanges();

            var debitLine = new iFINANCE.TransactionLine
            {
                debitedAmount = amount,
                creditedAmount = 0,
                comment = view.GetComment(),
                MasterAccounts = systemModel.MasterAccounts.Find(debitAccountId),
                MasterAccounts1 = systemModel.MasterAccounts.Find(creditAccountId),
                Transaction = transaction
            };

            var creditLine = new iFINANCE.TransactionLine
            {
                debitedAmount = 0,
                creditedAmount = amount,
                comment = view.GetComment(),
                MasterAccounts = systemModel.MasterAccounts.Find(creditAccountId),
                MasterAccounts1 = systemModel.MasterAccounts.Find(debitAccountId),
                Transaction = transaction
            };

            systemModel.TransactionLines.Add(debitLine);
            systemModel.TransactionLines.Add(creditLine);
            systemModel.SaveChanges();

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

