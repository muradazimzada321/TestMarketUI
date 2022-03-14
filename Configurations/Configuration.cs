using TestMarketUI.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketUI.Configurations
{
    static class Configuration
    {
        public static string ServerName;
        public static string DataBaseName;
        public const string pathConfigText = @"C:\Users\User\source\repos\TestMarketUI\Configurations\Configuration.json";
        public static bool WriteConfiguationData(string servername, string dbname)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder()
                { DataSource = servername, InitialCatalog = dbname, IntegratedSecurity = true };
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    File.WriteAllText(pathConfigText, JsonConvert.SerializeObject(builder));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Given info not correct.Try again.");
                return false;
            }
            return true;
        }
        public static bool CheckExist()
        {
            if (File.Exists(pathConfigText) && !File.ReadAllText(pathConfigText).IsNull())
            {
                return true;
            }
            return false;
        }
        public static bool CheckConnectionInfo()
        {
            try
            {
                string json = File.ReadAllText(pathConfigText);
                using (SqlConnection connection = new SqlConnection
                     (JsonConvert.DeserializeObject<SqlConnectionStringBuilder>(json).ConnectionString))
                {
                    ServerName = connection.DataSource;
                    DataBaseName = connection.Database;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
