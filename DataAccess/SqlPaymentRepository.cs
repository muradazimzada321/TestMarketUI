using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMarketUI.Entities;
using TestMarketUI.Contracts;
using System.Data;

namespace TestMarketUI.DataAccess
{
   public class SqlPaymentRepository: IPaymentRepository
    {
        private readonly string connectionString;
        public SqlPaymentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool CreatePayment(Credit credit)
        {
            throw new NotImplementedException();
        }

        public bool DeletePayments(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadPayments()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePayment(int id)
        {
            throw new NotImplementedException();
        }
    }
}
