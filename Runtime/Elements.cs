﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epidemic.Runtime.Elements
{
    public class Box : Element
    {
        public Box()
        {
            type = "Box";
            elem.Name = type;
        }
    }
}
