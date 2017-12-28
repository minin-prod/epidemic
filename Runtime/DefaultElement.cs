using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic.Runtime.Elements
{
    public class ElementControl : UserControl
    {
        public ElementControl()
        {
            // Init Values
            Anchor = AnchorStyles.None;
            Viewable = true;
            ParentNode = null;
        }

        #region Events
        // Properties
        [Category("Events"), Description("Ran when the element loads."), DesignOnly(true)]
        public string event_OnLoad { get; set; }

        // Functions
        public void OnLoad() { }
        #endregion

        [Browsable(false)]
        override public AnchorStyles Anchor { get; set; }
        [Category("Epidemic"), Description("Is this element viewable in the final version?"), DesignOnly(true)]
        public bool Viewable { get; set; }
        [Category("Epidemic"), Description("Parent element of this element."), DesignOnly(true)]
        public Control ParentNode { get; set; }
    }

    public class Element
    {
        public void Init(EngineWindow p)
        {
            parent = p;
            if (p.IsEditor)
                elem.Visible = true;
            else
                elem.Visible = elem.Viewable;
        }

        #region Variables
        public EngineWindow parent;
        public ElementControl elem;
        public string type;
        #endregion
    }
}
