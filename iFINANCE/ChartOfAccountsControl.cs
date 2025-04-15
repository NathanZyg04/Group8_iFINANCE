using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iFINANCE
{
    class ChartOfAccountsControl
    {
        private static ChartOfAccountsForm _view;     // set the link to the view
        private iFINANCEModel systemModel = new iFINANCEModel();  // set the link to the model

        public void ChartOfAccountsForm_Load(object sender, EventArgs e)
        {
            _view = (ChartOfAccountsForm)sender;
            // fill the acGroupNameBox with main categories, main groups and sub groups
            var GroupsNamesBoxDataSource = new List<Group>();
            var GridGroupsNamesBoxDataSource = new List<Group>();
            foreach (var group in systemModel.Groups)
            {
                Group oneGroup = new Group() { ID = group.ID, name = getGroupName(group) };
                GroupsNamesBoxDataSource.Add(oneGroup);
                GridGroupsNamesBoxDataSource.Add(oneGroup);
            }
            _view.populateGroupsNamesBox(GroupsNamesBoxDataSource);
            _view.populateGridGroupsNamesBox(GridGroupsNamesBoxDataSource);

            // fill the list with the existing master accounts
            int row = 0;
            foreach (var account in systemModel.MasterAccounts)
            {
                var group = systemModel.Groups.Find(account.Group.ID);
                _view.addGridRow(row, account.ID.ToString(), account.name, (double)account.openingAmount, 
                    (double)account.closingAmount, (int)account.Group.ID);
                row++;
            }

            _view.setContextMenu();
        }
        private string getGroupName(Group g)
        {
            if (g.parent == null)
            {
                var category = systemModel.AccountCategories.Find(Convert.ToInt32(g.AccountCategory.ID));
                return category.name + "\\" + g.name;

            }
            else
            {
                var parentGroup = systemModel.Groups.Find(Convert.ToInt32(g.parent.ID));
                return getGroupName(parentGroup) + "\\" + g.name;
            }
        }

        public void changNameItem_Click(object sender, EventArgs e)
        {
            _view = (ChartOfAccountsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();

            int row = _view.List().CurrentCell.RowIndex;
            int col = _view.List().CurrentCell.ColumnIndex;
            _view.List().CurrentCell = _view.List()[col, row];
            _view.List().BeginEdit(true);

        }

        public void accountsGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _view = (ChartOfAccountsForm)((DataGridView)sender).FindForm();

            int ID = Convert.ToInt32(_view.List()[0, e.RowIndex].Value);
            String newUpdate = _view.List()[e.ColumnIndex, e.RowIndex].Value.ToString();
            if (e.ColumnIndex == 1) changeName(ID, newUpdate);
            else if (e.ColumnIndex == 2) changeOpenAmount(ID, newUpdate);
            else if (e.ColumnIndex == 4) changeGroup(ID, newUpdate);
        }

        private void changeName(int ID, String value)
        {
            var theAccount = systemModel.MasterAccounts.Find(ID);
            theAccount.name = value;
            systemModel.SaveChanges();
        }

        private void changeOpenAmount(int ID, String value)
        {
            var theAccount = systemModel.MasterAccounts.Find(ID);
            theAccount.openingAmount = double.Parse(value);
            systemModel.SaveChanges();
        }

        private void changeGroup(int ID, String value)
        {
            var parentGroup = systemModel.Groups.Find(Convert.ToInt32(value));
            var theAccount = systemModel.MasterAccounts.Find(ID);
            theAccount.Group = parentGroup;
            systemModel.SaveChanges();
        }

        public void addAccountItem_Click(object sender, EventArgs e)
        {
            _view = (ChartOfAccountsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();
            _view.setFocus();
        }

        public void addAccountBtn_Click(object sender, EventArgs e)
        {
            _view = (ChartOfAccountsForm)((Button)sender).FindForm();
            if (_view.acName == "" || _view.acOAmount =="")
            {
                _view.showErrorMessage("Invalid Entry");
            }
            else
            {
               
                var parentGroup = systemModel.Groups.Find(Convert.ToInt32(_view.acGroupID()));

                MasterAccount account = new MasterAccount();
                account.name = _view.acName;
                account.openingAmount = double.Parse(_view.acOAmount);
                account.closingAmount = 0;
                account.Group = parentGroup;
                systemModel.MasterAccounts.Add(account);
                systemModel.SaveChanges();

                int row = _view.List().Rows.Count;
                _view.addGridRow(row, account.ID.ToString(), account.name, (double)account.openingAmount, (double)account.closingAmount, (int)account.Group.ID);

                _view.clear();
            }
        }
        public void removeAccount_Click(object sender, EventArgs e)
        {
            _view = (ChartOfAccountsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();


            int ID = Convert.ToInt32(_view.List()[0, _view.List().CurrentRow.Index].Value);
            var masterAccount = systemModel.MasterAccounts.Find(ID);
            systemModel.MasterAccounts.Remove(masterAccount);
            systemModel.SaveChanges();
            // update the view
            _view.removeLine(_view.List().CurrentRow.Index);

        }
    }
}
