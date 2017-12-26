using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic.Runtime.Elements
{
    public class Element
    {
        public Control elem = new Panel();
        public string type;

        public void Init()
        {
            elem.BackColor = Color.Black;
            elem.Width = 100;
            elem.Height = 100;
            elem.Location = new Point(0,0);
        }
    }
}
