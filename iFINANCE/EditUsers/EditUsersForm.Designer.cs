namespace iFINANCE
{
    partial class EditUsersForm
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
            this.userListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(17, 56);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(159, 204);
            this.userListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(211, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(124, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(211, 108);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(124, 20);
            this.addressTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(211, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(124, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(222, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(222, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(222, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(222, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(211, 211);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(124, 20);
            this.usernameTextBox.TabIndex = 8;
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(217, 258);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(117, 25);
            this.editUserButton.TabIndex = 10;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.Red;
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.deleteUserButton.Location = new System.Drawing.Point(19, 280);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(156, 23);
            this.deleteUserButton.TabIndex = 11;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            // 
            // EditUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userListBox);
            this.Name = "EditUsersForm";
            this.Text = "EditUsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
    }
}