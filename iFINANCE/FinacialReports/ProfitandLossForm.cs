using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace iFINANCE.FinacialReports
{
    public partial class ProfitandLossForm : Form
    {
        private readonly ProfitandLossController controller;

        public ProfitandLossForm()
        {
            InitializeComponent();
            controller = new ProfitandLossController(this); // Initialize the controller and pass the form (View) to it
        }

        private void ProfitandLossForm_Load(object sender, EventArgs e)
        {
            // Load the Profit and Loss data when the form loads
            controller.LoadProfitAndLossData();
        }

        // Method to display the Profit and Loss data in the form
        public void DisplayProfitAndLossData(
            List<ProfitAndLossRow> incomeAccounts,
            List<ProfitAndLossRow> expenseAccounts,
            double totalIncome,
            double totalExpenses,
            double profitOrLoss)
        {
            // Clear existing rows in the Income DataGridView
            incomeDataGridView.Rows.Clear();
            foreach (var income in incomeAccounts)
            {
                incomeDataGridView.Rows.Add(income.AccountName, income.Amount.ToString("C"));
            }

            // Clear existing rows in the Expense DataGridView
            expenseDataGridView.Rows.Clear();
            foreach (var expense in expenseAccounts)
            {
                expenseDataGridView.Rows.Add(expense.AccountName, expense.Amount.ToString("C"));
            }

            // Display totals and profit/loss
            totalIncomeTextBox.Text = totalIncome.ToString("C2");
            totalExpensesTextBox.Text = totalExpenses.ToString("C2");

            double diff = Math.Abs(totalIncome) - totalExpenses;

            profitOrLossTextBox.Text = diff.ToString("C");

                   

            profitOrLossTextBox.Text = diff < 0
                ? $"-${Math.Abs(diff):N2}" // Format as -$200.00
                : $"${diff:N2}";          // Format as $200.00

            // Display profit or loss (negative value will automatically show as a loss)
            //profitOrLossTextBox.Text = profitOrLoss.ToString("C2"); // Format as currency
        }

        // Method to show error messages
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
