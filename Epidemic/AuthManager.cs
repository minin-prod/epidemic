using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epidemic.Assets;
using Epidemic.Builder;

namespace Epidemic.Auth
{
    class AuthManager
    {
        #region Functions
        public static void validateLogin(string name, string pass)
        {
            if (name == "" && pass == "")
            {
                AuthToken loginState = createTokenAuth(UserType.Guest);
                loginHandler(loginState, UserType.Guest);
            }
            else if (name != "" && pass == "")
            {
                MessageBox.Show("Missing Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name == "" && pass != "")
            {
                MessageBox.Show("Missing Username!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AuthToken loginState = createTokenAuth(UserType.Proper, name, pass);
                loginHandler(loginState, UserType.Proper);
            }
        }

        public static AuthToken createTokenAuth(UserType type, string name = "guest", string pass = "login")
        {
            try
            {
                if (type == UserType.Guest && isGuest(name, pass))
                {
                    AuthToken tokenObject = new AuthToken();
                    tokenObject.State = ApplicationState.Authenticated;

                    return tokenObject;
                }
                else if (type == UserType.Proper && !isGuest(name, pass))
                {
                    AuthToken tokenObject = new AuthToken();
                    tokenObject.State = ApplicationState.Success;

                    return tokenObject;
                }
                else
                {
                    AuthToken tokenObject = new AuthToken();
                    tokenObject.State = ApplicationState.Ok;

                    return tokenObject;
                }
            }
            catch
            {
                MessageBox.Show("An error occured while authenticating", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                AuthToken tokenObject = new AuthToken();
                tokenObject.State = ApplicationState.Failiure;

                return tokenObject;
            }
        }

        public static void loginHandler(AuthToken state, UserType type)
        {
            if (state.State == ApplicationState.Success && type == UserType.Proper)
            {
                var answer = MessageBox.Show("Account doesn't exist, would you like to create one?", "Login Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes)
                    redirect("register", "invalidAccount");
            }
            else if (state.State == ApplicationState.Authenticated)
            {
                Builder.Builder builder = new Builder.Builder(state);
                Process.Start(builder.fetchPath() + $@"\EpidemicBuilder.exe");
                Login.ActiveForm.Close();
            }
        }
        #endregion

        #region Tools
        public static bool isGuest(string name, string pass) => new Tools().isGuest(name, pass);
        public static void redirect(string loc, string method) => Process.Start("https://soon-tm.weebly.com/redirect?=" + loc + "&src=" + method);
        #endregion
    }
}
