namespace iFINANCE
{
    partial class AccountsGroupsForm
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
            this.components = new System.ComponentModel.Container();
            this.groupsTree = new System.Windows.Forms.TreeView();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nodeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changNameItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeGroupItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addGroupBtn = new System.Windows.Forms.Button();
            this.gNameBox = new System.Windows.Forms.TextBox();
            this.gNameLable = new System.Windows.Forms.Label();
            this.nodeContextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupsTree
            // 
            this.groupsTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsTree.HideSelection = false;
            this.groupsTree.LabelEdit = true;
            this.groupsTree.Location = new System.Drawing.Point(30, 77);
            this.groupsTree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupsTree.Name = "groupsTree";
            this.groupsTree.Size = new System.Drawing.Size(586, 419);
            this.groupsTree.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(636, 470);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(188, 26);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Custom Accounts Groups Form";
            // 
            // nodeContextMenu
            // 
            this.nodeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changNameItem,
            this.addGroupItem,
            this.removeGroupItem});
            this.nodeContextMenu.Name = "nodeContextMenu";
            this.nodeContextMenu.Size = new System.Drawing.Size(154, 70);
            // 
            // changNameItem
            // 
            this.changNameItem.Name = "changNameItem";
            this.changNameItem.Size = new System.Drawing.Size(153, 22);
            this.changNameItem.Text = "Change Name";
            // 
            // addGroupItem
            // 
            this.addGroupItem.Name = "addGroupItem";
            this.addGroupItem.Size = new System.Drawing.Size(153, 22);
            this.addGroupItem.Text = "Add Group";
            // 
            // removeGroupItem
            // 
            this.removeGroupItem.Name = "removeGroupItem";
            this.removeGroupItem.Size = new System.Drawing.Size(153, 22);
            this.removeGroupItem.Text = "Remove Group";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addGroupBtn);
            this.groupBox1.Controls.Add(this.gNameBox);
            this.groupBox1.Controls.Add(this.gNameLable);
            this.groupBox1.Location = new System.Drawing.Point(636, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 367);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Group";
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Location = new System.Drawing.Point(93, 136);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.Size = new System.Drawing.Size(75, 23);
            this.addGroupBtn.TabIndex = 2;
            this.addGroupBtn.Text = "Add";
            this.addGroupBtn.UseVisualStyleBackColor = true;
            // 
            // gNameBox
            // 
            this.gNameBox.Location = new System.Drawing.Point(19, 89);
            this.gNameBox.Name = "gNameBox";
            this.gNameBox.Size = new System.Drawing.Size(149, 24);
            this.gNameBox.TabIndex = 1;
            // 
            // gNameLable
            // 
            this.gNameLable.AutoSize = true;
            this.gNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gNameLable.Location = new System.Drawing.Point(16, 60);
            this.gNameLable.Name = "gNameLable";
            this.gNameLable.Size = new System.Drawing.Size(85, 16);
            this.gNameLable.TabIndex = 0;
            this.gNameLable.Text = "Group Name";
            this.gNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountsGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 528);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupsTree);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountsGroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AccountsGroups";
            this.nodeContextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView groupsTree;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip nodeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changNameItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupItem;
        private System.Windows.Forms.ToolStripMenuItem removeGroupItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addGroupBtn;
        private System.Windows.Forms.TextBox gNameBox;
        private System.Windows.Forms.Label gNameLable;
    }
}