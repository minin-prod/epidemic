using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Epidemic.Auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Functions
        void login() => AuthManager.validateLogin(usernameBox.Text, passwordBox.Text);
        #endregion

        #region Event Handlers
        // Login Button
        private void loginPanel_Click(object sender, EventArgs e) => login();
        private void loginLabel_Click(object sender, EventArgs e) => login();
        // Register Button
        private void registerPanel_Click(object sender, EventArgs e) => AuthManager.redirect("register", "appRegButton");
        #endregion
    }
}
