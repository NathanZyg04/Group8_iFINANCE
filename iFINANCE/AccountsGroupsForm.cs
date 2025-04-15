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
    public partial class AccountsGroupsForm : Form
    {
        AccountsGroupsControl groupsControl;  // set the link to the control
        public AccountsGroupsForm()
        {
            InitializeComponent();

            groupsControl = new AccountsGroupsControl();
            this.Load += new System.EventHandler(groupsControl.AccountsGroupsForm_Load);
            this.groupsTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(groupsControl.groupsTree_AfterLabelEdit);
            this.changNameItem.Click += new System.EventHandler(groupsControl.changNameItem_Click);
            this.addGroupItem.Click += new System.EventHandler(groupsControl.addGroupItem_Click);
            this.exitBtn.Click += new System.EventHandler(groupsControl.exitBtn_Click);
            this.addGroupBtn.Click += new System.EventHandler(groupsControl.addGroupBtn_Click);
            this.removeGroupItem.Click += new System.EventHandler(groupsControl.removeGroupItem_Click);
        }
       
        private void setContextMenu(TreeNode treeNode)
        {
            foreach (TreeNode tn in treeNode.Nodes)
            {
                tn.ContextMenuStrip = this.nodeContextMenu;
                setContextMenu(tn);
            }
        }

      
        public void updateTree(TreeNode toNode)
        {
           this.BeginInvoke(new Action(() => groupsControl.changeGroupName(toNode)));
        }

        public void showErrorMessage(String msg)
        {
          MessageBox.Show(msg, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public TreeView Tree()
        {
            return this.groupsTree;
        }

        public string groupName
        {
            get
            {
                return this.gNameBox.Text;
            }
            set
            {
                this.gNameBox.Text = value;
            }
        }

        public void addCategoryNode(String key, String data)
        {
            TreeNode node = groupsTree.Nodes.Add(key, data, key);
        }

        public void addGroupNode(String key, String data)
        {
            TreeNode node = groupsTree.SelectedNode.Nodes.Add(key, data, key);
            node.ContextMenuStrip = this.nodeContextMenu;
        }

        public void addSubGroupNode(TreeNode parent, String key, String data)
        {
            TreeNode node = parent.Nodes.Add(key, data, key);
            node.ContextMenuStrip = this.nodeContextMenu;
        }

        public void removeNode(TreeNode node)
        {
            groupsTree.Nodes.Remove(node);
        }

        public void setFocus()
        {
            this.gNameBox.Focus();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
