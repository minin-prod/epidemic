using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic.Builder
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        #region Functions
        public TreeNodeCollection Open(TreeNodeCollection c)
        {
            tree.Nodes.Clear();
            foreach (TreeNode n in c)
                tree.Nodes.Add(n.Text);

            ShowDialog();
            return tree.Nodes;
        }
        #endregion

        #region Events
        private void sbDismiss_Click(object sender, EventArgs e) => Close();

        private void sbUp_Click(object sender, EventArgs e)
        {
            var s = tree.SelectedNode;
            if (s != null)
                if (s.Index != 0)
                    tree.SelectedNode = tree.Nodes[tree.SelectedNode.Index - 1];
        }

        private void sbDown_Click(object sender, EventArgs e)
        {
            var s = tree.SelectedNode;
            if (s != null)
                if (s.Index != tree.Nodes.Count-1)
                    tree.SelectedNode = tree.Nodes[tree.SelectedNode.Index + 1];
        }
        #endregion
    }
}
