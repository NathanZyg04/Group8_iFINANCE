namespace iFINANCE
{
    partial class DoubleEntryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox debitAccountComboBox;
        private System.Windows.Forms.ComboBox creditAccountComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker transactionDatePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox transactionNumberTextBox;
        private System.Windows.Forms.TextBox totalDebitTextBox;
        private System.Windows.Forms.TextBox totalCreditTextBox;
        private System.Windows.Forms.DataGridView transactionLinesDataGridView;
        private System.Windows.Forms.Label transactionNumberLabel;
        private System.Windows.Forms.Label transactionDateLabel;
        private System.Windows.Forms.Label debitAccountLabel;
        private System.Windows.Forms.Label creditAccountLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label totalDebitLabel;
        private System.Windows.Forms.Label totalCreditLabel;
        private System.Windows.Forms.Label transactionLinesLabel;
        private System.Windows.Forms.Button newTransactionButton;

        private void InitializeComponent()
        {
            this.debitAccountComboBox = new System.Windows.Forms.ComboBox();
            this.creditAccountComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.transactionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.transactionNumberTextBox = new System.Windows.Forms.TextBox();
            this.totalDebitTextBox = new System.Windows.Forms.TextBox();
            this.totalCreditTextBox = new System.Windows.Forms.TextBox();
            this.transactionLinesDataGridView = new System.Windows.Forms.DataGridView();
            this.transactionNumberLabel = new System.Windows.Forms.Label();
            this.transactionDateLabel = new System.Windows.Forms.Label();
            this.debitAccountLabel = new System.Windows.Forms.Label();
            this.creditAccountLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.totalDebitLabel = new System.Windows.Forms.Label();
            this.totalCreditLabel = new System.Windows.Forms.Label();
            this.transactionLinesLabel = new System.Windows.Forms.Label();
            this.newTransactionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionLinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // debitAccountComboBox
            // 
            this.debitAccountComboBox.FormattingEnabled = true;
            this.debitAccountComboBox.Location = new System.Drawing.Point(30, 130);
            this.debitAccountComboBox.Name = "debitAccountComboBox";
            this.debitAccountComboBox.Size = new System.Drawing.Size(200, 21);
            this.debitAccountComboBox.TabIndex = 5;
            // 
            // creditAccountComboBox
            // 
            this.creditAccountComboBox.FormattingEnabled = true;
            this.creditAccountComboBox.Location = new System.Drawing.Point(30, 180);
            this.creditAccountComboBox.Name = "creditAccountComboBox";
            this.creditAccountComboBox.Size = new System.Drawing.Size(200, 21);
            this.creditAccountComboBox.TabIndex = 7;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(30, 230);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 20);
            this.amountTextBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(30, 280);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(30, 330);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 20);
            this.commentTextBox.TabIndex = 13;
            // 
            // transactionDatePicker
            // 
            this.transactionDatePicker.Location = new System.Drawing.Point(30, 80);
            this.transactionDatePicker.Name = "transactionDatePicker";
            this.transactionDatePicker.Size = new System.Drawing.Size(200, 20);
            this.transactionDatePicker.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(30, 460);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(200, 30);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save Transaction";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(250, 460);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(200, 30);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "Update Transaction";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(470, 460);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(200, 30);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete Transaction";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // transactionNumberTextBox
            // 
            this.transactionNumberTextBox.Location = new System.Drawing.Point(30, 30);
            this.transactionNumberTextBox.Name = "transactionNumberTextBox";
            this.transactionNumberTextBox.ReadOnly = true;//should not be editable by user
            this.transactionNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.transactionNumberTextBox.TabIndex = 1;
            // 
            // totalDebitTextBox
            // 
            this.totalDebitTextBox.Location = new System.Drawing.Point(30, 380);
            this.totalDebitTextBox.Name = "totalDebitTextBox";
            this.totalDebitTextBox.ReadOnly = true;//not editiable by user
            this.totalDebitTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalDebitTextBox.TabIndex = 15;
            // 
            // totalCreditTextBox
            // 
            this.totalCreditTextBox.Location = new System.Drawing.Point(30, 430);
            this.totalCreditTextBox.Name = "totalCreditTextBox";
            this.totalCreditTextBox.ReadOnly = true;//not editiable by user
            this.totalCreditTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalCreditTextBox.TabIndex = 17;
            // 
            // transactionLinesDataGridView
            // 
            this.transactionLinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionLinesDataGridView.Location = new System.Drawing.Point(250, 30);
            this.transactionLinesDataGridView.Name = "transactionLinesDataGridView";
            this.transactionLinesDataGridView.RowHeadersWidth = 92;
            this.transactionLinesDataGridView.Size = new System.Drawing.Size(570, 420);
            this.transactionLinesDataGridView.TabIndex = 19;
            // 
            // transactionNumberLabel
            // 
            this.transactionNumberLabel.AutoSize = true;
            this.transactionNumberLabel.Location = new System.Drawing.Point(30, 10);
            this.transactionNumberLabel.Name = "transactionNumberLabel";
            this.transactionNumberLabel.Size = new System.Drawing.Size(103, 13);
            this.transactionNumberLabel.TabIndex = 0;
            this.transactionNumberLabel.Text = "Transaction Number";
            // 
            // transactionDateLabel
            // 
            this.transactionDateLabel.AutoSize = true;
            this.transactionDateLabel.Location = new System.Drawing.Point(30, 60);
            this.transactionDateLabel.Name = "transactionDateLabel";
            this.transactionDateLabel.Size = new System.Drawing.Size(89, 13);
            this.transactionDateLabel.TabIndex = 2;
            this.transactionDateLabel.Text = "Transaction Date";
            // 
            // debitAccountLabel
            // 
            this.debitAccountLabel.AutoSize = true;
            this.debitAccountLabel.Location = new System.Drawing.Point(30, 110);
            this.debitAccountLabel.Name = "debitAccountLabel";
            this.debitAccountLabel.Size = new System.Drawing.Size(75, 13);
            this.debitAccountLabel.TabIndex = 4;
            this.debitAccountLabel.Text = "Debit Account";
            // 
            // creditAccountLabel
            // 
            this.creditAccountLabel.AutoSize = true;
            this.creditAccountLabel.Location = new System.Drawing.Point(30, 160);
            this.creditAccountLabel.Name = "creditAccountLabel";
            this.creditAccountLabel.Size = new System.Drawing.Size(77, 13);
            this.creditAccountLabel.TabIndex = 6;
            this.creditAccountLabel.Text = "Credit Account";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(30, 210);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(30, 260);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(30, 310);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(51, 13);
            this.commentLabel.TabIndex = 12;
            this.commentLabel.Text = "Comment";
            // 
            // totalDebitLabel
            // 
            this.totalDebitLabel.AutoSize = true;
            this.totalDebitLabel.Location = new System.Drawing.Point(30, 360);
            this.totalDebitLabel.Name = "totalDebitLabel";
            this.totalDebitLabel.Size = new System.Drawing.Size(59, 13);
            this.totalDebitLabel.TabIndex = 14;
            this.totalDebitLabel.Text = "Total Debit";
            // 
            // totalCreditLabel
            // 
            this.totalCreditLabel.AutoSize = true;
            this.totalCreditLabel.Location = new System.Drawing.Point(30, 410);
            this.totalCreditLabel.Name = "totalCreditLabel";
            this.totalCreditLabel.Size = new System.Drawing.Size(61, 13);
            this.totalCreditLabel.TabIndex = 16;
            this.totalCreditLabel.Text = "Total Credit";
            // 
            // transactionLinesLabel
            // 
            this.transactionLinesLabel.AutoSize = true;
            this.transactionLinesLabel.Location = new System.Drawing.Point(250, 10);
            this.transactionLinesLabel.Name = "transactionLinesLabel";
            this.transactionLinesLabel.Size = new System.Drawing.Size(91, 13);
            this.transactionLinesLabel.TabIndex = 18;
            this.transactionLinesLabel.Text = "Transaction Lines";
            // 
            // newTransactionButton
            // 
            this.newTransactionButton.Location = new System.Drawing.Point(690, 460);
            this.newTransactionButton.Name = "newTransactionButton";
            this.newTransactionButton.Size = new System.Drawing.Size(200, 30);
            this.newTransactionButton.TabIndex = 23;
            this.newTransactionButton.Text = "New Transaction";
            this.newTransactionButton.UseVisualStyleBackColor = true;
            this.newTransactionButton.Click += new System.EventHandler(this.newTransactionButton_Click);
            // 
            // DoubleEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 534);
            this.Controls.Add(this.newTransactionButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.transactionLinesDataGridView);
            this.Controls.Add(this.transactionLinesLabel);
            this.Controls.Add(this.totalCreditTextBox);
            this.Controls.Add(this.totalCreditLabel);
            this.Controls.Add(this.totalDebitTextBox);
            this.Controls.Add(this.totalDebitLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.creditAccountComboBox);
            this.Controls.Add(this.creditAccountLabel);
            this.Controls.Add(this.debitAccountComboBox);
            this.Controls.Add(this.debitAccountLabel);
            this.Controls.Add(this.transactionDatePicker);
            this.Controls.Add(this.transactionDateLabel);
            this.Controls.Add(this.transactionNumberTextBox);
            this.Controls.Add(this.transactionNumberLabel);
            this.Name = "DoubleEntryForm";
            this.Text = "Double Entry Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.transactionLinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
