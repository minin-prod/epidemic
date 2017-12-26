using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epidemic.Assets
{
    #region Enums
    public enum UserType
    {
        Guest,
        Proper
    }

    public enum ApplicationState
    {
        Success,
        Authenticated,
        Ok,
        Failiure
    }
    #endregion

    #region Classes
    public class Tools
    {
        public bool isGuest(string name, string pass) => name == "guest" && pass == "login";
    }

    public class AuthToken
    {
        public ApplicationState State = ApplicationState.Success;
        public string Username = "guest";
        public string Password = "login";
        public bool isGuest => new Tools().isGuest(Username, Password);
    }
    #endregion
}
