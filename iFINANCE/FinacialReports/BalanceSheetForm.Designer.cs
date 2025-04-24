namespace iFINANCE.FinacialReports
{
    partial class BalanceSheetForm
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
            this.assetDataGridView = new System.Windows.Forms.DataGridView();
            this.assetsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liabiltiesTextBox = new System.Windows.Forms.TextBox();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liabilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liabilitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // assetDataGridView
            // 
            this.assetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountName,
            this.GroupName,
            this.TransID,
            this.TotalDebit,
            this.TotalCredit});
            this.assetDataGridView.Location = new System.Drawing.Point(12, 54);
            this.assetDataGridView.Name = "assetDataGridView";
            this.assetDataGridView.Size = new System.Drawing.Size(497, 377);
            this.assetDataGridView.TabIndex = 0;
            // 
            // assetsTextBox
            // 
            this.assetsTextBox.Location = new System.Drawing.Point(98, 457);
            this.assetsTextBox.Name = "assetsTextBox";
            this.assetsTextBox.Size = new System.Drawing.Size(123, 20);
            this.assetsTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Assets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Liabilties:";
            // 
            // liabiltiesTextBox
            // 
            this.liabiltiesTextBox.Location = new System.Drawing.Point(422, 457);
            this.liabiltiesTextBox.Name = "liabiltiesTextBox";
            this.liabiltiesTextBox.Size = new System.Drawing.Size(123, 20);
            this.liabiltiesTextBox.TabIndex = 3;
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "AccountName";
            this.AccountName.Name = "AccountName";
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "GroupName";
            this.GroupName.Name = "GroupName";
            // 
            // TransID
            // 
            this.TransID.HeaderText = "TransID";
            this.TransID.Name = "TransID";
            this.TransID.Width = 50;
            // 
            // TotalDebit
            // 
            this.TotalDebit.HeaderText = "TotalDebit";
            this.TotalDebit.Name = "TotalDebit";
            // 
            // TotalCredit
            // 
            this.TotalCredit.HeaderText = "TotalCredit";
            this.TotalCredit.Name = "TotalCredit";
            // 
            // liabilitiesDataGridView
            // 
            this.liabilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liabilitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.liabilitiesDataGridView.Location = new System.Drawing.Point(555, 54);
            this.liabilitiesDataGridView.Name = "liabilitiesDataGridView";
            this.liabilitiesDataGridView.Size = new System.Drawing.Size(497, 377);
            this.liabilitiesDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "AccountName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "GroupName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "TransID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "TotalDebit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "TotalCredit";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assets + Inventory";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(552, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Liabilites + Profit/Loss";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BalanceSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 740);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liabilitiesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.liabiltiesTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assetsTextBox);
            this.Controls.Add(this.assetDataGridView);
            this.Name = "BalanceSheetForm";
            this.Text = "BalanceSheetForm";
            ((System.ComponentModel.ISupportInitialize)(this.assetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liabilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView assetDataGridView;
        private System.Windows.Forms.TextBox assetsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox liabiltiesTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCredit;
        private System.Windows.Forms.DataGridView liabilitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}