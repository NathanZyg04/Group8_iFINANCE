using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    public partial class ChartOfAccountsForm : Form
    {
        ChartOfAccountsControl accountsControl;  // set the link to the control
        public ChartOfAccountsForm()
        {
            InitializeComponent();

            accountsControl = new ChartOfAccountsControl();

            this.Load += new System.EventHandler(accountsControl.ChartOfAccountsForm_Load);
            this.accountsGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(accountsControl.accountsGrid_CellEndEdit);
            this.changNameItem.Click += new System.EventHandler(accountsControl.changNameItem_Click);
            this.addAccountItem.Click += new System.EventHandler(accountsControl.addAccountItem_Click);
            this.addAccountBtn.Click += new System.EventHandler(accountsControl.addAccountBtn_Click);
            this.removeAccountItem.Click += new System.EventHandler(accountsControl.removeAccount_Click);
        }


        public void setContextMenu()
        {
             
            for (int row = 0; row < accountsGrid.Rows.Count; row++)
            {
                this.accountsGrid.Rows[row].ContextMenuStrip = this.lineContextMenu;
            }
        }

        public void showErrorMessage(String msg)
        {
            MessageBox.Show(msg, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataGridView List()
        {
            return this.accountsGrid;
        }

        public void populateGroupsNamesBox(List<Group> DS)
        {
            this.acGroupNameBox.DataSource = DS;
            this.acGroupNameBox.DisplayMember = "name";
            this.acGroupNameBox.ValueMember = "ID";
        }

        public void populateGridGroupsNamesBox(List<Group> DS)
        {
            this.acGridGroupName.DataSource = DS;
            this.acGridGroupName.DisplayMember = "name";
            this.acGridGroupName.ValueMember = "ID";
        }

        public string acName
        {
            get
            {
                return this.acAccountNameBox1.Text;
            }
            set
            {
                this.acAccountNameBox1.Text = value;
            }
        }
        public string acOAmount
        {
            get
            {
                return this.acOpenAmountBox1.Text;
            }
            set
            {
                this.acOpenAmountBox1.Text = value;
            }
        }
        public string acGroupID()
        {
            return acGroupNameBox.SelectedValue.ToString();
        }

        public void clear()
        {
            acOAmount = "";
            acName = "";
        }


        public void addGridRow(int row, String no, String name, double oAmount, double cAmount, int value)
        {
            int rowNumber = accountsGrid.Rows.Add(no, name, oAmount.ToString(), cAmount.ToString(), (int) value);

            this.accountsGrid.Rows[rowNumber].ContextMenuStrip = this.lineContextMenu;
        }

        public void removeLine(int index)
        {
            this.accountsGrid.Rows.RemoveAt(index);
        }

        public void setFocus()
        {
            this.acAccountNameBox1.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}