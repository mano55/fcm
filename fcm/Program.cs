using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fcm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CGuiApplicationIntermediate cgai = CGuiApplicationIntermediate.InstanceCreation();
            Console.WriteLine("Version: " + Environment.Version.ToString());

            Application.Run(new FormLogIn());
;
        }
    }
}
