using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing.OSE.UI.MonitorApp
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
            //AppDomain.CurrentDomain.SetData("DataDirectory", Environment.CurrentDirectory);
            var dataBaseDir = ConfigurationManager.AppSettings["DataBaseDir"];
            AppDomain.CurrentDomain.SetData("DataDirectory", dataBaseDir);
            Application.Run(new MDIMain());
        }
    }
}
