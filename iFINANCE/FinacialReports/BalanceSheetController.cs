using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE.FinacialReports
{
    internal class BalanceSheetController
    {
        private iFINANCEModel systemModel = new iFINANCEModel();
        private BalanceSheetForm _view;


        public void BalanceSheetForm_Load(object sender, EventArgs e)
        {
            _view = (BalanceSheetForm)sender;


            // load the data
            LoadBalanceSheetInfo();
        }

        // loads the balance sheet info
        public void LoadBalanceSheetInfo()
        {

            try
            {
                List<BalanceSheetRow> rows = GetAssetBalanceSheetDataForUser(_view.getUserID());
                List<BalanceSheetRow> rows2 = GetLiabilitesBalanceSheetDataForUser(_view.getUserID());


                //double totalDebit = rows.Sum(row => row.TotalDebit);
                //double totalCredit = rows.Sum(row => row.TotalCredit);

                _view.displayBalanceSheetInfo(rows, rows2, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Trial Balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private List<BalanceSheetRow> GetAssetBalanceSheetDataForUser(int nonAdminUserID)
        {

            var balanceSheetRows = systemModel.MasterAccounts
                .Where(ma => ma.NonAdminUser_ID == nonAdminUserID)
                // Join the Groups for each Master Account for that user
                .Join(systemModel.Groups, 
                    ma => ma.Group.ID,
                    g => g.ID,
                    (ma, g) => new { 
                        MasterAccount = ma, 
                        Group = g 
                    })
                // Group by Master Account its group and category
                .Join(systemModel.AccountCategories,
                    mg => mg.Group.AccountCategory.ID,
                    ac => ac.ID,
                    (mg, ac) => new
                    {
                        MasterAccount = mg.MasterAccount,
                        Group = mg.Group,
                        Category = ac
                    })
                // Only get the objects that have an account category of 1 (asset)
                .Where(m => m.Category.ID == 1)
                .Join(systemModel.TransactionLines,
                    mac => mac.MasterAccount.ID,
                    tl => tl.MasterAccounts.ID,
                    (mac, tl) => new BalanceSheetRow{
                        AccountName = mac.MasterAccount.name,
                        GroupName = mac.Group.name,
                        CategoryName = mac.Category.name,
                        TransactionID = tl.ID,
           
                        Debit = tl.debitedAmount,
                        Credit = tl.creditedAmount
                    })
                .ToList();

            return balanceSheetRows;

        }

    

     private List<BalanceSheetRow> GetLiabilitesBalanceSheetDataForUser(int nonAdminUserID)
        {

            var balanceSheetRows = systemModel.MasterAccounts
                .Where(ma => ma.NonAdminUser_ID == nonAdminUserID)
                // Join the Groups for each Master Account for that user
                .Join(systemModel.Groups,
                    ma => ma.Group.ID,
                    g => g.ID,
                    (ma, g) => new {
                        MasterAccount = ma,
                        Group = g
                    })
                // Group by Master Account its group and category
                .Join(systemModel.AccountCategories,
                    mg => mg.Group.AccountCategory.ID,
                    ac => ac.ID,
                    (mg, ac) => new
                    {
                        MasterAccount = mg.MasterAccount,
                        Group = mg.Group,
                        Category = ac
                    })
                // Only get the objects that have an account category of 1 (liabilites)
                .Where(m => m.Category.ID == 2)
                .Join(systemModel.TransactionLines,
                    mac => mac.MasterAccount.ID,
                    tl => tl.MasterAccounts.ID,
                    (mac, tl) => new BalanceSheetRow
                    {
                        AccountName = mac.MasterAccount.name,
                        GroupName = mac.Group.name,
                        CategoryName = mac.Category.name,
                        TransactionID = tl.ID,

                        Debit = tl.debitedAmount,
                        Credit = tl.creditedAmount
                    })
                .ToList();

            return balanceSheetRows;

        }

    }

    // class to be used for the info to be displayed in the data view
    public class BalanceSheetRow
    {
        public int AccountCategory_ID { get; set; }
        public string AccountName { get; set; }
        public string GroupName { get; set; }
        public string CategoryName { get; set; }
        public int TransactionID { get; set; }

        public double Debit { get; set; }
        public double Credit { get; set; }



    }
}
