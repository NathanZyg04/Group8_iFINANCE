using iFINANCE.DoubleEntryTransactions;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;

namespace iFINANCE
{
    public partial class DoubleEntryForm : Form
    {
        private DoubleEntryController controller;
        private int currentTransactionId; 

        public DoubleEntryForm(int userId, int transactionId = 0)
        {
            InitializeComponent();
            controller = new DoubleEntryController(this, userId, transactionId);
            currentTransactionId = transactionId; //Initialize the currentTransactionId
            LoadTransactionDetails(transactionId); //Load transaction details
        }

        // Methods to update the UI based on the controller's actions
        public void SetTransactionNumber(string number)
        {
            transactionNumberTextBox.Text = number;
        }

        public void SetDescription(string description)
        {
            descriptionTextBox.Text = description;
        }

        public void SetComment(string comment)
        {
            commentTextBox.Text = comment;
        }

        public void SetAmount(string amount)
        {
            amountTextBox.Text = amount;
        }

        public void SetTransactionDate(DateTime date)
        {
            transactionDatePicker.Value = date;
        }

        public void SetDebitAccount(int accountId)
        {
            debitAccountComboBox.SelectedValue = accountId;
        }

        public void SetCreditAccount(int accountId)
        {
            creditAccountComboBox.SelectedValue = accountId;
        }

        public void SetTransactionLines(List<TransactionLine> lines)
        {
            var displayLines = lines.Select(line => new TransactionLineDisplay
            {
                AccountNumber = line.MasterAccounts.ID,
                AccountName = line.MasterAccounts.name,
                DebitAmount = line.debitedAmount,
                CreditAmount = line.creditedAmount,
                Comment = line.comment
            }).ToList();

            transactionLinesDataGridView.DataSource = displayLines;
            UpdateTotalAmounts(lines); //Update total amounts
        }

        public void SetDebitAccountComboBox(List<MasterAccount> accounts)
        {
            debitAccountComboBox.DataSource = new BindingSource(accounts, null);
            debitAccountComboBox.DisplayMember = "name";
            debitAccountComboBox.ValueMember = "ID";
        }

        public void SetCreditAccountComboBox(List<MasterAccount> accounts)
        {
            creditAccountComboBox.DataSource = new BindingSource(accounts, null);
            creditAccountComboBox.DisplayMember = "name";
            creditAccountComboBox.ValueMember = "ID";
        }

        public void ClearTransactionLines()
        {
            transactionLinesDataGridView.DataSource = null;
            totalDebitTextBox.Text = "0";
            totalCreditTextBox.Text = "0";
            transactionNumberTextBox.Text = "";
            descriptionTextBox.Text = "";
            commentTextBox.Text = "";
            amountTextBox.Text = "";
            transactionDatePicker.Value = DateTime.Now;
            debitAccountComboBox.SelectedIndex = -1;
            creditAccountComboBox.SelectedIndex = -1;
        }

        public void ClearForm()
        {
            currentTransactionId = 0;
            transactionNumberTextBox.Text = "";
            amountTextBox.Text = "";
            descriptionTextBox.Text = "";
            commentTextBox.Text = "";
            transactionDatePicker.Value = DateTime.Now;
            debitAccountComboBox.SelectedIndex = 0;
            creditAccountComboBox.SelectedIndex = 0;
            totalDebitTextBox.Text = "";
            totalCreditTextBox.Text = "";
            transactionLinesDataGridView.DataSource = null;
        }

        public string GetAmount()
        {
            return amountTextBox.Text;
        }

        public int GetDebitAccountId()
        {
            return (int)debitAccountComboBox.SelectedValue;
        }

        public int GetCreditAccountId()
        {
            return (int)creditAccountComboBox.SelectedValue;
        }

        public DateTime GetTransactionDate()
        {
            return transactionDatePicker.Value;
        }

        public string GetDescription()
        {
            return descriptionTextBox.Text;
        }

        public string GetComment()
        {
            return commentTextBox.Text;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        // Event handlers
        private void saveButton_Click(object sender, EventArgs e)
        {
            controller.SaveTransaction();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            controller.UpdateTransaction();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller.DeleteTransaction();
        }

        private void newTransactionButton_Click(object sender, EventArgs e)
        {
            controller.NewTransaction();
        }

        private void UpdateTotalAmounts(List<TransactionLine> lines)
        {
            double totalDebit = lines.Sum(line => line.debitedAmount);
            double totalCredit = lines.Sum(line => line.creditedAmount);
            totalDebitTextBox.Text = totalDebit.ToString("F2");
            totalCreditTextBox.Text = totalCredit.ToString("F2");
        }

        private void LoadTransactionDetails(int transactionId)
        {
            if (transactionId > 0)
            {
                var transaction = controller.GetTransactionById(transactionId);
                if (transaction != null)
                {
                    SetTransactionNumber(transaction.ID.ToString());
                    SetTransactionDate(transaction.date);
                    SetDescription(transaction.description);
                    //previous implementation kept for use in case something is broken
                    //SetComment(transaction.comment);
                    //SetAmount(transaction.amount.ToString("F2"));
                    //SetDebitAccount(transaction.debitAccountId);
                    //SetCreditAccount(transaction.creditAccountId);
                    //SetTransactionLines(transaction.TransactionLines.ToList());
                }
            }
        }
    }

    public class TransactionLineDisplay
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public double DebitAmount { get; set; }
        public double CreditAmount { get; set; }
        public string Comment { get; set; }
    }
}

