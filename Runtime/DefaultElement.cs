using System;
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
            Viewable = true;
        }

        [Browsable(false)]
        override public AnchorStyles Anchor { get; set; }
        [Category("Epidemic"), Description("Is this element viewable in the actual program?")]
        public bool Viewable { get; set; }
    }

    public class Element
    {
        public void Init(EngineWindow parent)
        {
            if (parent.IsEditor)
                elem.Visible = true;
            else
                elem.Visible = elem.Viewable;
        }

        #region Variables
        public ElementControl elem;
        public string type;
        #endregion
    }
}
