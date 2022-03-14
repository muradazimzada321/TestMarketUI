
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketUI.Extensions
{
    public static class SqlReaderExtension
    {


        public static int GetInt32 (this SqlDataReader reader,string columnname)
        {
            return reader.GetInt32(reader.GetOrdinal(columnname));
        }
        public static string GetString(this SqlDataReader reader, string columnname)
        {
            return reader.GetString(reader.GetOrdinal(columnname));
        }
        
    }

}
