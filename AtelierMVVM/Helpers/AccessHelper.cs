using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierMVVM.Helpers
{
    class AccessHelper
    {

        [STAThread] // Le model de Thread qui sera appelé - 
        [System.Runtime.InteropServices.DllImport("advapi32.dll")] // import de bibliotheque
        public static extern bool LogonUser(string userName, string domainName, string password, int LogonType, int LogonProvider, ref IntPtr phToken);
        

        //public static bool IsAuthentificationCorrect(string userName, string password)
        //{

        //    //recher si ok
        //    return true; 
        //}
    }
}
