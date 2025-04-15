namespace iFINANCE
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.editUsers = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAccountGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.function2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.function3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // editUsers
            // 
            this.editUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageAccountGroupToolStripMenuItem,
            this.function2ToolStripMenuItem,
            this.function3ToolStripMenuItem,
            this.financialReportsToolStripMenuItem,
            this.ChangePasswordMenuItem,
            this.windowToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.editUsersToolStripMenuItem});
            this.editUsers.Location = new System.Drawing.Point(0, 0);
            this.editUsers.MdiWindowListItem = this.windowToolStripMenuItem;
            this.editUsers.Name = "editUsers";
            this.editUsers.Size = new System.Drawing.Size(1296, 27);
            this.editUsers.TabIndex = 0;
            this.editUsers.Text = "Edit Users";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageAccountGroupToolStripMenuItem
            // 
            this.manageAccountGroupToolStripMenuItem.Name = "manageAccountGroupToolStripMenuItem";
            this.manageAccountGroupToolStripMenuItem.Size = new System.Drawing.Size(168, 23);
            this.manageAccountGroupToolStripMenuItem.Text = "Manage Account Group";
            this.manageAccountGroupToolStripMenuItem.Click += new System.EventHandler(this.manageAccountGroupToolStripMenuItem_Click);
            // 
            // function2ToolStripMenuItem
            // 
            this.function2ToolStripMenuItem.Name = "function2ToolStripMenuItem";
            this.function2ToolStripMenuItem.Size = new System.Drawing.Size(131, 23);
            this.function2ToolStripMenuItem.Text = "Chart of Accounts";
            this.function2ToolStripMenuItem.Click += new System.EventHandler(this.function2ToolStripMenuItem_Click);
            // 
            // function3ToolStripMenuItem
            // 
            this.function3ToolStripMenuItem.Name = "function3ToolStripMenuItem";
            this.function3ToolStripMenuItem.Size = new System.Drawing.Size(182, 23);
            this.function3ToolStripMenuItem.Text = "Double-Entry Transactions";
            // 
            // financialReportsToolStripMenuItem
            // 
            this.financialReportsToolStripMenuItem.Name = "financialReportsToolStripMenuItem";
            this.financialReportsToolStripMenuItem.Size = new System.Drawing.Size(124, 23);
            this.financialReportsToolStripMenuItem.Text = "Financial Reports";
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(130, 23);
            this.ChangePasswordMenuItem.Text = "Change Password";
            this.ChangePasswordMenuItem.Click += new System.EventHandler(this.ChangePasswordMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.tileHorizontalToolStripMenuItem.Text = "TileHorizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.tileVerticalToolStripMenuItem.Text = "TileVertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // editUsersToolStripMenuItem
            // 
            this.editUsersToolStripMenuItem.Name = "editUsersToolStripMenuItem";
            this.editUsersToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.editUsersToolStripMenuItem.Text = "Edit Users";
            this.editUsersToolStripMenuItem.Click += new System.EventHandler(this.editUsersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iFINANCE.Properties.Resources.UMBackground;
            this.ClientSize = new System.Drawing.Size(1296, 825);
            this.Controls.Add(this.editUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.editUsers;
            this.Name = "MainForm";
            this.Text = "iFINANCE";
            this.editUsers.ResumeLayout(false);
            this.editUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip editUsers;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAccountGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem function2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem function3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUsersToolStripMenuItem;
    }
}

