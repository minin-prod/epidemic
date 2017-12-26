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

namespace Epidemic.Builder
{
    public partial class Builder : Form
    {
        public AuthToken userAuth = new AuthToken();

        public Builder(AuthToken login)
        {
            InitializeComponent();

            userAuth = login;
        }
        
        public string fetchPath() => Directory.GetCurrentDirectory();
    }
}
