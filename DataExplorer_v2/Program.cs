using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataExplorer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (args.Length > 0)
                    Application.Run(new frmMain(args[0]));
                else
                    Application.Run(new frmMain());
            }
            catch (Exception ex)
            { MessageBox.Show(string.Format("An unexpected error has occured:\n\n{0}\n\nApplication Version: {1}\n{2}", ex.Message, Application.ProductVersion, ex.ToString()), "Unhandled Error"); }
        }
        public static void OnExcept(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unexpected error has occured:\n\n" + e.ExceptionObject.ToString(), "Unhandled Exception");
            Application.Exit();
        }
    }
}