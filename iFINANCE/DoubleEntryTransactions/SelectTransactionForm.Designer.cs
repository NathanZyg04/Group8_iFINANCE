namespace iFINANCE
{
    partial class SelectTransactionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.Button selectButton;

        private void InitializeComponent()
        {
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.Size = new System.Drawing.Size(760, 400);
            this.transactionsDataGridView.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(12, 420);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(760, 30);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select Transaction";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SelectTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.transactionsDataGridView);
            this.Name = "SelectTransactionForm";
            this.Text = "Select Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
