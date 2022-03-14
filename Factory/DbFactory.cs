using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMarketUI.Contracts;
using TestMarketUI.DataAccess;
using TestMarketUI.SqlServerTypes;

namespace TestMarketUI.Factory
{
   public static class DbFactory
    {

        public static IUnitOfWork Create (ServerType serverType, string servername, string databasename)
        {
            if (serverType == ServerType.MSSQL)
                return new SqlUnitOfWork(servername, databasename);
           //else if (serverType == ServerType.MYSQL)
           // {
           //     return new MySqlUnitOfWork(servername, databasename);
           // }
            throw new NotSupportedException("Not Supported");
        }
    }
}
