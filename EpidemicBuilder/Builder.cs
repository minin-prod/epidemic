using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epidemic.Assets;
using Epidemic.Runtime;
using Epidemic.Runtime.Elements;

namespace Epidemic.Builder
{
    public partial class Builder : Form
    {
        public Runtime.Console c;
        public Element selectedElem;
        public AuthToken user = new AuthToken();

        public Builder(AuthToken login)
        {
            InitializeComponent();

            user = login;
        }

        #region Functions
        public string fetchPath() => Directory.GetCurrentDirectory();
        public void updateElem() => selectedElem.elem = (ElementControl)propertiesContent.SelectedObject;
        #endregion

        #region Event Handlers
        #region Builder Form
        private void Builder_Load(object sender, EventArgs e)
        {
            // Disable Paid Options
            if (user.isGuest() || !user.isPro)
            {
                Text += " - Free";
            }
            else // Enable Paid Options
            {
                Text += " - Pro";
            }

            // Create Console
            c = consoleContent;
            c.Text = "Welcome to Epidemic Builder!";

            // Configure EngineWindows
            editorEngine.Init();
            previewEngine.Init();

            // Load Toolbox Options
            var types = new string[] { "Box" };

            toolboxContents.Items.Clear();
            foreach (string type in types)
            {
                toolboxContents.Items.Add(type);
            }
        }
        #endregion
         
        #region Toolbox
        private void toolboxContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolboxContents.SelectedItem != null)
            {
                var elem = toolboxContents.SelectedItem.ToString();
                var selected = false;
                Element selectedElem = new Element();

                if (elem == "Box") { selectedElem = new Box(); selected = true; }

                if (selected)
                {
                    if (editorTabs.SelectedIndex == 0)
                    {
                        editorEngine.addElement(selectedElem);
                    }
                    else
                    {
                        previewEngine.addElement(selectedElem);
                    }
                    hierarchyContent.Nodes.Add(elem);
                }
            }
        }
        #endregion

        #region Editor/Preview
        private void editorTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editorTabs.SelectedIndex == 0)
            {
                editorEngine.elemRegistry = previewEngine.elemRegistry;

                editorEngine.render();
            }
            else
            {
                previewEngine.elemRegistry = editorEngine.elemRegistry;

                previewEngine.render();
            }
        }

        private void editorReloadButton_Click(object sender, EventArgs e)
        {

            if (editorTabs.SelectedIndex == 0)
                editorEngine.render();
            else
                previewEngine.render();
        }
        #endregion

        #region Hierarchy
        private void hierarchyContent_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (Element elem in editorEngine.elemRegistry)
            {
                if (elem.elem.Name == e.Node.Text)
                {
                    propertiesContent.SelectedObject = elem.elem;
                    selectedElem = elem;
                    break;
                }
            }
        }

        private void hierarchyManageButton_Click(object sender, EventArgs e)
        {
            var HierarchyManager = new Manager();
            var c = HierarchyManager.Open(hierarchyContent.Nodes);

            hierarchyContent.Nodes.Clear();
            foreach (TreeNode n in c)
                hierarchyContent.Nodes.Add(n.Text);
        }
        #endregion

        #region Properties
        private void propertiesContent_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) => updateElem();
        #endregion
        #endregion
    }
}
