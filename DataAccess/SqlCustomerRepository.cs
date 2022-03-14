using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMarketUI.Contracts;
using TestMarketUI.Entities;

namespace TestMarketUI.DataAccess
{
   public class SqlCustomerRepository : ICustomerRepository
    {
        private readonly string connectionString;
        public SqlCustomerRepository(string connectionsString)
        {
            this.connectionString = connectionsString;
        }


        public bool CreateCustomer (Customer customer)
        {
            // to do
            return true;
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool ReadCustomers ()
        {
            return true;

        }
        public bool UpdateCustomer()
        {
            return true;
        }

        public bool UpdateCustomer(int id)
        {
            throw new NotImplementedException();
        }

        DataTable ICustomerRepository.ReadCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
 