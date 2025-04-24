using System;
using System.Collections.Generic;
using System.Linq;

namespace iFINANCE.FinacialReports
{
    internal class ProfitandLossController
    {
        private readonly iFINANCEModel systemModel;
        private readonly ProfitandLossForm view;

        public ProfitandLossController(ProfitandLossForm view)
        {
            this.view = view;
            this.systemModel = new iFINANCEModel(); // Initialize the database context
        }

        public void LoadProfitAndLossData()
        {
            try
            {
                // Fetch Income and Expense categories from AccountCategories table
                var incomeCategory = systemModel.AccountCategories.FirstOrDefault(ac => ac.name == "Income");
                var expenseCategory = systemModel.AccountCategories.FirstOrDefault(ac => ac.name == "Expenses");

                if (incomeCategory == null || expenseCategory == null)
                {
                    view.ShowError("Income or Expenses category not found in the database.");
                    return;
                }

                // Fetch Group IDs with AccountCategory_ID matching the Income and Expense categories
                var incomeGroupIds = systemModel.Groups
                    .Where(g => g.AccountCategory.ID == incomeCategory.ID)
                    .Select(g => g.ID)
                    .ToList();

                var expenseGroupIds = systemModel.Groups
                    .Where(g => g.AccountCategory.ID == expenseCategory.ID)
                    .Select(g => g.ID)
                    .ToList();

                // Fetch MasterAccounts for Income Groups
                var incomeAccounts = systemModel.MasterAccounts
                    .Where(ma => incomeGroupIds.Contains(ma.Group.ID))
                    .Select(ma => new ProfitAndLossRow
                    {
                        AccountName = ma.name,
                        Amount = ma.closingAmount ?? 0
                    }).ToList();

                // Fetch MasterAccounts for Expense Groups
                var expenseAccounts = systemModel.MasterAccounts
                    .Where(ma => expenseGroupIds.Contains(ma.Group.ID))
                    .Select(ma => new ProfitAndLossRow
                    {
                        AccountName = ma.name,
                        Amount = ma.closingAmount ?? 0
                    }).ToList();

                // Calculate totals
                double totalIncome = incomeAccounts.Sum(i => i.Amount);
                double totalExpenses = expenseAccounts.Sum(e => e.Amount);
                double profitOrLoss = totalIncome - totalExpenses;

                // Pass the data to the view for display
                view.DisplayProfitAndLossData(incomeAccounts, expenseAccounts, totalIncome, totalExpenses, profitOrLoss);
            }
            catch (Exception ex)
            {
                view.ShowError($"Error loading Profit and Loss data: {ex.Message}");
            }

    }
}

    public class ProfitAndLossRow
    {
        public string AccountName { get; set; }
        public double Amount { get; set; }
    }
}
