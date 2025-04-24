namespace iFINANCE.FinacialReports
{
    partial class TrialBalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.trialBalanceDataGridView = new System.Windows.Forms.DataGridView();
            this.AccountNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DebitAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDebitLabel = new System.Windows.Forms.Label();
            this.totalCreditLabel = new System.Windows.Forms.Label();
            this.totalDebitTextBox = new System.Windows.Forms.TextBox();
            this.totalCreditTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trialBalanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trialBalanceDataGridView
            // 
            this.trialBalanceDataGridView.AllowUserToAddRows = false;
            this.trialBalanceDataGridView.AllowUserToDeleteRows = false;
            this.trialBalanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trialBalanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNameColumn,
            this.DebitAmountColumn,
            this.CreditAmountColumn});
            this.trialBalanceDataGridView.Location = new System.Drawing.Point(12, 12);
            this.trialBalanceDataGridView.Name = "trialBalanceDataGridView";
            this.trialBalanceDataGridView.ReadOnly = true;
            this.trialBalanceDataGridView.Size = new System.Drawing.Size(560, 300);
            this.trialBalanceDataGridView.TabIndex = 0;
            // 
            // AccountNameColumn
            // 
            this.AccountNameColumn.HeaderText = "Account Name";
            this.AccountNameColumn.Name = "AccountNameColumn";
            this.AccountNameColumn.ReadOnly = true;
            this.AccountNameColumn.Width = 200;
            // 
            // DebitAmountColumn
            // 
            this.DebitAmountColumn.HeaderText = "Debit Amount";
            this.DebitAmountColumn.Name = "DebitAmountColumn";
            this.DebitAmountColumn.ReadOnly = true;
            this.DebitAmountColumn.Width = 150;
            // 
            // CreditAmountColumn
            // 
            this.CreditAmountColumn.HeaderText = "Credit Amount";
            this.CreditAmountColumn.Name = "CreditAmountColumn";
            this.CreditAmountColumn.ReadOnly = true;
            this.CreditAmountColumn.Width = 150;
            // 
            // totalDebitLabel
            // 
            this.totalDebitLabel.AutoSize = true;
            this.totalDebitLabel.Location = new System.Drawing.Point(12, 330);
            this.totalDebitLabel.Name = "totalDebitLabel";
            this.totalDebitLabel.Size = new System.Drawing.Size(65, 13);
            this.totalDebitLabel.TabIndex = 1;
            this.totalDebitLabel.Text = "Total Debit:";
            // 
            // totalCreditLabel
            // 
            this.totalCreditLabel.AutoSize = true;
            this.totalCreditLabel.Location = new System.Drawing.Point(300, 330);
            this.totalCreditLabel.Name = "totalCreditLabel";
            this.totalCreditLabel.Size = new System.Drawing.Size(68, 13);
            this.totalCreditLabel.TabIndex = 2;
            this.totalCreditLabel.Text = "Total Credit:";
            // 
            // totalDebitTextBox
            // 
            this.totalDebitTextBox.Location = new System.Drawing.Point(83, 327);
            this.totalDebitTextBox.Name = "totalDebitTextBox";
            this.totalDebitTextBox.ReadOnly = true;
            this.totalDebitTextBox.Size = new System.Drawing.Size(150, 20);
            this.totalDebitTextBox.TabIndex = 3;
            // 
            // totalCreditTextBox
            // 
            this.totalCreditTextBox.Location = new System.Drawing.Point(374, 327);
            this.totalCreditTextBox.Name = "totalCreditTextBox";
            this.totalCreditTextBox.ReadOnly = true;
            this.totalCreditTextBox.Size = new System.Drawing.Size(150, 20);
            this.totalCreditTextBox.TabIndex = 4;
            // 
            // TrialBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.totalCreditTextBox);
            this.Controls.Add(this.totalDebitTextBox);
            this.Controls.Add(this.totalCreditLabel);
            this.Controls.Add(this.totalDebitLabel);
            this.Controls.Add(this.trialBalanceDataGridView);
            this.Name = "TrialBalanceForm";
            this.Text = "Trial Balance";
            this.Load += new System.EventHandler(this.TrialBalanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trialBalanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView trialBalanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DebitAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditAmountColumn;
        private System.Windows.Forms.Label totalDebitLabel;
        private System.Windows.Forms.Label totalCreditLabel;
        private System.Windows.Forms.TextBox totalDebitTextBox;
        private System.Windows.Forms.TextBox totalCreditTextBox;
    }
}
