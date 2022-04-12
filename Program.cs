using System;
using System.Windows.Forms;
using TestMarketUI.Configurations;

namespace TestMarketUI
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Configuration.CheckExist() && Configuration.CheckConnectionInfo())
            {
                Console.WriteLine("Appliaction Started...");
            }
            else

            {
                Application.Run(new ServerConnection());
                return;
            }
            Console.WriteLine("Connected...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBoard());
        }
    }
}
