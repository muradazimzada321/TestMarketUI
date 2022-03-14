using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMarketUI.Contracts;

namespace TestMarketUI.DataAccess
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private readonly string connectionString;

        public SqlUnitOfWork(string serverName, string dataBaseName)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = serverName;
            builder.InitialCatalog = dataBaseName;
            builder.IntegratedSecurity = true;
            connectionString = builder.ConnectionString;
        }

        public ICreditRepository CreditRepository { get => new SqlCreditRepository(this.connectionString); }
        public ICustomerRepository CustomerRepository => new SqlCustomerRepository(this.connectionString);
        public IPaymentRepository PaymentRepository => new SqlPaymentRepository(this.connectionString);

    }
}
