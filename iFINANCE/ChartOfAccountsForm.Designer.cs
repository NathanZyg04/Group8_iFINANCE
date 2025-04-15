namespace iFINANCE
{
    partial class ChartOfAccountsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.acGroupNameLable = new System.Windows.Forms.Label();
            this.acGroupNameBox = new System.Windows.Forms.ComboBox();
            this.acOpeninAmountLabel = new System.Windows.Forms.Label();
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.acNameLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lineContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changNameItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsGrid = new System.Windows.Forms.DataGridView();
            this.acGridNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acGridOpenAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acGridCloseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acGridGroupName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.acOpenAmountBox1 = new iFINANCE.acOpenAmountBox();
            this.acAccountNameBox1 = new iFINANCE.acAccountNameBox();
            this.groupBox1.SuspendLayout();
            this.lineContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.acOpenAmountBox1);
            this.groupBox1.Controls.Add(this.acAccountNameBox1);
            this.groupBox1.Controls.Add(this.acGroupNameLable);
            this.groupBox1.Controls.Add(this.acGroupNameBox);
            this.groupBox1.Controls.Add(this.acOpeninAmountLabel);
            this.groupBox1.Controls.Add(this.addAccountBtn);
            this.groupBox1.Controls.Add(this.acNameLable);
            this.groupBox1.Location = new System.Drawing.Point(25, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 220);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Master Account";
            // 
            // acGroupNameLable
            // 
            this.acGroupNameLable.AutoSize = true;
            this.acGroupNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acGroupNameLable.Location = new System.Drawing.Point(92, 115);
            this.acGroupNameLable.Name = "acGroupNameLable";
            this.acGroupNameLable.Size = new System.Drawing.Size(85, 16);
            this.acGroupNameLable.TabIndex = 6;
            this.acGroupNameLable.Text = "Group Name";
            this.acGroupNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acGroupNameBox
            // 
            this.acGroupNameBox.FormattingEnabled = true;
            this.acGroupNameBox.Location = new System.Drawing.Point(183, 114);
            this.acGroupNameBox.Name = "acGroupNameBox";
            this.acGroupNameBox.Size = new System.Drawing.Size(245, 21);
            this.acGroupNameBox.TabIndex = 5;
            // 
            // acOpeninAmountLabel
            // 
            this.acOpeninAmountLabel.AutoSize = true;
            this.acOpeninAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acOpeninAmountLabel.Location = new System.Drawing.Point(63, 78);
            this.acOpeninAmountLabel.Name = "acOpeninAmountLabel";
            this.acOpeninAmountLabel.Size = new System.Drawing.Size(114, 16);
            this.acOpeninAmountLabel.TabIndex = 3;
            this.acOpeninAmountLabel.Text = "Openning Amount";
            this.acOpeninAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Location = new System.Drawing.Point(353, 168);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(75, 23);
            this.addAccountBtn.TabIndex = 2;
            this.addAccountBtn.Text = "Add";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            // 
            // acNameLable
            // 
            this.acNameLable.AutoSize = true;
            this.acNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acNameLable.Location = new System.Drawing.Point(81, 40);
            this.acNameLable.Name = "acNameLable";
            this.acNameLable.Size = new System.Drawing.Size(96, 16);
            this.acNameLable.TabIndex = 0;
            this.acNameLable.Text = "Account Name";
            this.acNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chart of Accounts Form";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(647, 525);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(121, 26);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lineContextMenu
            // 
            this.lineContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changNameItem,
            this.addAccountItem,
            this.removeAccountItem});
            this.lineContextMenu.Name = "nodeContextMenu";
            this.lineContextMenu.Size = new System.Drawing.Size(166, 70);
            // 
            // changNameItem
            // 
            this.changNameItem.Name = "changNameItem";
            this.changNameItem.Size = new System.Drawing.Size(165, 22);
            this.changNameItem.Text = "Change Account";
            // 
            // addAccountItem
            // 
            this.addAccountItem.Name = "addAccountItem";
            this.addAccountItem.Size = new System.Drawing.Size(165, 22);
            this.addAccountItem.Text = "Add Account";
            // 
            // removeAccountItem
            // 
            this.removeAccountItem.Name = "removeAccountItem";
            this.removeAccountItem.Size = new System.Drawing.Size(165, 22);
            this.removeAccountItem.Text = "Remove Account";
            // 
            // accountsGrid
            // 
            this.accountsGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.accountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acGridNumber,
            this.acGridName,
            this.acGridOpenAmount,
            this.acGridCloseAmount,
            this.acGridGroupName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.accountsGrid.Location = new System.Drawing.Point(25, 71);
            this.accountsGrid.Name = "accountsGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.accountsGrid.Size = new System.Drawing.Size(762, 231);
            this.accountsGrid.TabIndex = 9;
            // 
            // acGridNumber
            // 
            this.acGridNumber.HeaderText = "Number";
            this.acGridNumber.Name = "acGridNumber";
            this.acGridNumber.ReadOnly = true;
            this.acGridNumber.Width = 50;
            // 
            // acGridName
            // 
            this.acGridName.HeaderText = "Account Name";
            this.acGridName.Name = "acGridName";
            this.acGridName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acGridName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.acGridName.Width = 200;
            // 
            // acGridOpenAmount
            // 
            this.acGridOpenAmount.HeaderText = "Open Amount";
            this.acGridOpenAmount.Name = "acGridOpenAmount";
            this.acGridOpenAmount.Width = 70;
            // 
            // acGridCloseAmount
            // 
            this.acGridCloseAmount.HeaderText = "Closing Amount";
            this.acGridCloseAmount.Name = "acGridCloseAmount";
            this.acGridCloseAmount.ReadOnly = true;
            this.acGridCloseAmount.Width = 70;
            // 
            // acGridGroupName
            // 
            this.acGridGroupName.HeaderText = "Group Name";
            this.acGridGroupName.Name = "acGridGroupName";
            this.acGridGroupName.Width = 300;
            // 
            // acOpenAmountBox1
            // 
            this.acOpenAmountBox1.Location = new System.Drawing.Point(184, 78);
            this.acOpenAmountBox1.Name = "acOpenAmountBox1";
            this.acOpenAmountBox1.Size = new System.Drawing.Size(100, 20);
            this.acOpenAmountBox1.TabIndex = 8;
            // 
            // acAccountNameBox1
            // 
            this.acAccountNameBox1.Location = new System.Drawing.Point(183, 40);
            this.acAccountNameBox1.Name = "acAccountNameBox1";
            this.acAccountNameBox1.Size = new System.Drawing.Size(245, 20);
            this.acAccountNameBox1.TabIndex = 7;
            // 
            // ChartOfAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 581);
            this.ControlBox = false;
            this.Controls.Add(this.accountsGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Name = "ChartOfAccountsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChartOfAccountsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lineContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label acGroupNameLable;
        private System.Windows.Forms.ComboBox acGroupNameBox;
        private System.Windows.Forms.Label acOpeninAmountLabel;
        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.Label acNameLable;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip lineContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changNameItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountItem;
        private System.Windows.Forms.DataGridView accountsGrid;
        private acAccountNameBox acAccountNameBox1;
        private acOpenAmountBox acOpenAmountBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acGridNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn acGridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn acGridOpenAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn acGridCloseAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn acGridGroupName;
    }
}