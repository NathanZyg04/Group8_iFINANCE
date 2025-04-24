using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE.FinacialReports
{
    public partial class BalanceSheetForm : Form
    {
        private BalanceSheetController controller;
        private int nonAdminUserID;

        public BalanceSheetForm(int nonAdminUserID)
        {
            InitializeComponent();

            this.nonAdminUserID = nonAdminUserID;

            controller = new BalanceSheetController();

            this.Load += new System.EventHandler(controller.BalanceSheetForm_Load);

        }

        
        // getter fucntion for the non admin user's ID
        public int getUserID()
        {
            return nonAdminUserID;
        }

        // updae the table view info 
        public void displayBalanceSheetInfo(List<BalanceSheetRow> assetRows, List<BalanceSheetRow> liabilitesRow,double totalAssets, double totalLiabilities)
        {
            assetDataGridView.Rows.Clear();

            // update view for asset table
            foreach( var row in assetRows)
            {
                assetDataGridView.Rows.Add(row.AccountName,row.GroupName,row.TransactionID,row.Debit,row.Credit);
            }

            // update view for liabilite table
            foreach(var row in liabilitesRow)
            {
               liabilitiesDataGridView.Rows.Add(row.AccountName, row.GroupName, row.TransactionID, row.Debit, row.Credit);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
