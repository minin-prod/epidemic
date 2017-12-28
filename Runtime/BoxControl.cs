using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic.Runtime.Elements
{
    public partial class BoxControl : ElementControl
    {
        public BoxControl()
        {
            InitializeComponent();
        }

        private void BoxControl_Load(object sender, EventArgs e) => OnLoad();
    }
}
