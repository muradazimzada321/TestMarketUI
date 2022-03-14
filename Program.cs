using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMarketUI.Contracts;
using TestMarketUI.DataAccess;
using TestMarketUI.Entities;
using TestMarketUI.Configurations;
using TestMarketUI.Factory;
using TestMarketUI.SqlServerTypes;

namespace TestMarketUI
{

    
    static class Program
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

            { Application.Run(new ServerConnection());
                return;
            }
            Console.WriteLine("Connected...");
            ServerType serverType = ServerType.MSSQL;
            IUnitOfWork unitOfWork = DbFactory.Create(serverType,Configuration.ServerName,Configuration.DataBaseName);
            bool f = unitOfWork.CustomerRepository.CreateCustomer(new Customer());
            // configuration happens here
            // 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashBoard());
        
        }
    }
}
