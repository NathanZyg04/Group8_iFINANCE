using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFINANCE
{
    class AccountsGroupsControl
    {
        private static AccountsGroupsForm _view;     // set the link to the view
        private iFINANCEModel systemModel = new iFINANCEModel();  // set the link to the model

        public void AccountsGroupsForm_Load(object sender, EventArgs e)
        {
            _view = (AccountsGroupsForm)sender;

            // fill the tree with main categories
            int i = 0;
            foreach (var category in systemModel.AccountCategories)
            {
                _view.addCategoryNode(category.ID.ToString(), category.name);
                foreach (var group in systemModel.Groups)
                {
                    if (group.parent == null)
                    {
                        if (group.AccountCategory.ID == category.ID)
                        {
                            _view.addSubGroupNode(_view.Tree().Nodes[i], group.ID.ToString(), group.name);
                        }
                    }
                }
                i++;
            }

            // fill the tree with main groups and sub groups
            foreach (var group in systemModel.Groups)
            {
                if (!(group.parent == null))
                {
                    TreeNode[] _nodes = _view.Tree().Nodes.Find((group.parent.ID).ToString(), true);
                    _view.addSubGroupNode(_nodes[_nodes.Length - 1], group.ID.ToString(), group.name);
                }
            }
        }

       

        public void changNameItem_Click(object sender, EventArgs e)
        {
            _view = (AccountsGroupsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();
            TreeNode currentNode = _view.Tree().SelectedNode;
            currentNode.BeginEdit();
        }

        public void addGroupItem_Click(object sender, EventArgs e)
        {
            _view = (AccountsGroupsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();
            _view.setFocus();
        }

        public void groupsTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            TreeView currentNode = (TreeView)sender;
            _view = (AccountsGroupsForm)((TreeView)sender).FindForm();

            if (currentNode.SelectedNode.Level == 0)
            {
                e.CancelEdit = true;
                _view.showErrorMessage("The accounts categories can not be changed");
            }
            else
            {
                _view.updateTree(e.Node);
            }
        }

        public void changeGroupName(TreeNode to)
        {
            var theGroup = systemModel.Groups.Find(Convert.ToInt32(to.ImageKey));
            theGroup.name = to.Text;
            systemModel.SaveChanges();
        }

        public void exitBtn_Click(object sender, EventArgs e)
        {
            _view = (AccountsGroupsForm)((Button)sender).FindForm();
            _view.Close();
        }

        public void addGroupBtn_Click(object sender, EventArgs e)
        {
            _view = (AccountsGroupsForm)((Button)sender).FindForm();
            if ( !System.Text.RegularExpressions.Regex.IsMatch(_view.groupName, "^[a-zA-Z0-9]"))
            {
                _view.showErrorMessage("Invalid group name");
            }
            else
            {

                TreeNode root = _view.Tree().SelectedNode;
                while (root.Parent != null)
                {
                    root = root.Parent;
                }
                Group g = null;
                var parentGroup = systemModel.Groups.Find(Convert.ToInt32(_view.Tree().SelectedNode.ImageKey));
                var parentCategory = systemModel.AccountCategories.Find(Convert.ToInt32(root.Name));
                Group group = new Group();
                group.name = _view.groupName;
                group.parent = parentGroup;
                group.AccountCategory = parentCategory;
                g = systemModel.Groups.Add(group);
                systemModel.SaveChanges();

                _view.addGroupNode(g.ID.ToString(), _view.groupName);
                _view.groupName = "";
            }
        }

        public void removeGroupItem_Click(object sender, EventArgs e)
        {
            _view = (AccountsGroupsForm)((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.FindForm();
            TreeNode theNode = _view.Tree().SelectedNode;

            if (theNode.Level == 0)
            {
                _view.showErrorMessage("The accounts categories can not be removed");
            }
            else
            {
                if (theNode.Nodes.Count > 0)
                {
                    _view.showErrorMessage("You can not remove this group unless you remove all its sub groups");
                }
                else
                {
                    var theGroup = systemModel.Groups.Find(Convert.ToInt32(theNode.ImageKey));
                    if (theGroup.parent == null)
                    {
                        _view.showErrorMessage("Please do not delete me!");
                    } else
                    {
                        systemModel.Groups.Remove(theGroup);
                        systemModel.SaveChanges();

                        _view.removeNode(theNode);
                    }
                   
                }
            }
        }
    }
}



