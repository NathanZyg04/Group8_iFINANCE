using System;
using System.Linq;
using System.Windows.Forms;

namespace iFINANCE
{
    public partial class SelectTransactionForm : Form
    {
        private iFINANCEModel systemModel = new iFINANCEModel();
        private int currentUserId;

        public int SelectedTransactionId { get; private set; }

        public SelectTransactionForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            var transactions = systemModel.Transactions
                .Where(t => t.NonAdminUser.ID == currentUserId)
                .Select(t => new
                {
                    t.ID,
                    t.date,
                    t.description,
                    User = t.NonAdminUser.name
                })
                .ToList();

            transactionsDataGridView.DataSource = transactions;

            // Configure grid view columns
            transactionsDataGridView.Columns["ID"].HeaderText = "Transaction ID";
            transactionsDataGridView.Columns["date"].HeaderText = "Date";
            transactionsDataGridView.Columns["description"].HeaderText = "Description";
            transactionsDataGridView.Columns["User"].HeaderText = "User";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (transactionsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction.");
                return;
            }

            SelectedTransactionId = (int)transactionsDataGridView.SelectedRows[0].Cells["ID"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
