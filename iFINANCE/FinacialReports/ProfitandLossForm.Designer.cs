namespace iFINANCE.FinacialReports
{
    partial class ProfitandLossForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView incomeDataGridView;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private System.Windows.Forms.TextBox totalIncomeTextBox;
        private System.Windows.Forms.TextBox totalExpensesTextBox;
        private System.Windows.Forms.TextBox profitOrLossTextBox;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label totalExpensesLabel;
        private System.Windows.Forms.Label profitOrLossLabel;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.Label expensesLabel;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.incomeDataGridView = new System.Windows.Forms.DataGridView();
            this.expenseDataGridView = new System.Windows.Forms.DataGridView();
            this.totalIncomeTextBox = new System.Windows.Forms.TextBox();
            this.totalExpensesTextBox = new System.Windows.Forms.TextBox();
            this.profitOrLossTextBox = new System.Windows.Forms.TextBox();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.totalExpensesLabel = new System.Windows.Forms.Label();
            this.profitOrLossLabel = new System.Windows.Forms.Label();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.expensesLabel = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            this.SuspendLayout();

            // 
            // incomeDataGridView
            // 
            this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            var incomeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            incomeColumn1.Name = "AccountName1";
            incomeColumn1.HeaderText = "Account Name";
            incomeColumn1.Width = 200;

            var incomeColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            incomeColumn2.Name = "Amount1";
            incomeColumn2.HeaderText = "Amount";
            incomeColumn2.Width = 100;

            this.incomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            incomeColumn1, incomeColumn2
            });

            this.incomeDataGridView.Location = new System.Drawing.Point(12, 40);
            this.incomeDataGridView.Name = "incomeDataGridView";
            this.incomeDataGridView.Size = new System.Drawing.Size(360, 200);
            this.incomeDataGridView.TabIndex = 0;

            // 
            // expenseDataGridView
            // 
            this.expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            var expenseColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            expenseColumn1.Name = "AccountName";
            expenseColumn1.HeaderText = "Account Name";
            expenseColumn1.Width = 200;

            var expenseColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            expenseColumn2.Name = "Amount";
            expenseColumn2.HeaderText = "Amount";
            expenseColumn2.Width = 100;

            this.expenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
             expenseColumn1, expenseColumn2
            });

            this.expenseDataGridView.Location = new System.Drawing.Point(400, 40);
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.Size = new System.Drawing.Size(360, 200);
            this.expenseDataGridView.TabIndex = 1;

            // 
            // totalIncomeTextBox
            // 
            this.totalIncomeTextBox.Location = new System.Drawing.Point(100, 260);
            this.totalIncomeTextBox.Name = "totalIncomeTextBox";
            this.totalIncomeTextBox.ReadOnly = true;
            this.totalIncomeTextBox.Size = new System.Drawing.Size(120, 20);
            this.totalIncomeTextBox.TabIndex = 2;

            // 
            // totalExpensesTextBox
            // 
            this.totalExpensesTextBox.Location = new System.Drawing.Point(500, 260);
            this.totalExpensesTextBox.Name = "totalExpensesTextBox";
            this.totalExpensesTextBox.ReadOnly = true;
            this.totalExpensesTextBox.Size = new System.Drawing.Size(120, 20);
            this.totalExpensesTextBox.TabIndex = 3;

            // 
            // profitOrLossTextBox
            // 
            this.profitOrLossTextBox.Location = new System.Drawing.Point(300, 320);
            this.profitOrLossTextBox.Name = "profitOrLossTextBox";
            this.profitOrLossTextBox.ReadOnly = true;
            this.profitOrLossTextBox.Size = new System.Drawing.Size(200, 20);
            this.profitOrLossTextBox.TabIndex = 4;

            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Location = new System.Drawing.Point(12, 263);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(72, 13);
            this.totalIncomeLabel.TabIndex = 5;
            this.totalIncomeLabel.Text = "Total Income:";

            // 
            // totalExpensesLabel
            // 
            this.totalExpensesLabel.AutoSize = true;
            this.totalExpensesLabel.Location = new System.Drawing.Point(400, 263);
            this.totalExpensesLabel.Name = "totalExpensesLabel";
            this.totalExpensesLabel.Size = new System.Drawing.Size(84, 13);
            this.totalExpensesLabel.TabIndex = 6;
            this.totalExpensesLabel.Text = "Total Expenses:";

            // 
            // profitOrLossLabel
            // 
            this.profitOrLossLabel.AutoSize = true;
            this.profitOrLossLabel.Location = new System.Drawing.Point(220, 323);
            this.profitOrLossLabel.Name = "profitOrLossLabel";
            this.profitOrLossLabel.Size = new System.Drawing.Size(74, 13);
            this.profitOrLossLabel.TabIndex = 7;
            this.profitOrLossLabel.Text = "Profit or Loss:";

            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(12, 20);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(45, 13);
            this.incomeLabel.TabIndex = 8;
            this.incomeLabel.Text = "Income:";

            // 
            // expensesLabel
            // 
            this.expensesLabel.AutoSize = true;
            this.expensesLabel.Location = new System.Drawing.Point(400, 20);
            this.expensesLabel.Name = "expensesLabel";
            this.expensesLabel.Size = new System.Drawing.Size(56, 13);
            this.expensesLabel.TabIndex = 9;
            this.expensesLabel.Text = "Expenses:";

            // 
            // ProfitandLossForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.expensesLabel);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.profitOrLossLabel);
            this.Controls.Add(this.totalExpensesLabel);
            this.Controls.Add(this.totalIncomeLabel);
            this.Controls.Add(this.profitOrLossTextBox);
            this.Controls.Add(this.totalExpensesTextBox);
            this.Controls.Add(this.totalIncomeTextBox);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.incomeDataGridView);
            this.Name = "ProfitandLossForm";
            this.Text = "Profit and Loss Statement";
            this.Load += new System.EventHandler(this.ProfitandLossForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion
    }
}
