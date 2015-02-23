using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LynxPrivacyLib;

[assembly: log4net.Config.XmlConfigurator(ConfigFile="Log4Net.config", Watch = true)]

namespace LynxPrivacy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LynxPrivacyTopMDI());
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try {
                Exception ex = (Exception)e.ExceptionObject;
                log.Fatal("Unhandled Exception caught.", ex);
                DialogResult result = MessageBox.Show(ex.Message + ex.StackTrace, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally {
                Application.Exit();
            }
        }
    }


    public static class Global
    {
        public static KeyStoreDB keyDb { get; set; }
        public static string keyServerConnectionBase { get; set; }
    }
}
