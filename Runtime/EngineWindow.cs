using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epidemic.Assets;
using Epidemic.Runtime.Elements;

namespace Epidemic.Runtime
{
    public partial class EngineWindow : UserControl
    {
        #region Variables
        public List<Element> elemRegistry = new List<Element>();
        #endregion

        public EngineWindow()
        {
            InitializeComponent();
            IsEditor = false;
            PostProcessing = true;
        }

        public void Init()
        {
            if (IsEditor)
            {
                PostProcessing = false;
            }
        }

        #region Parameters
        public bool IsEditor { set; get; }
        public bool PostProcessing { set; get; }
        #endregion

        #region Functions
        public void addElement(Element elem)
        {
            elem.Init(this);
            elemRegistry.Add(elem);
            Controls.Add(elem.elem);
        }

        public void render()
        {
            Controls.Clear();
            foreach (Element elem in elemRegistry)
            {
                elem.Init(this);
                Controls.Add(elem.elem);
            }
        }
        #endregion
    }
}
