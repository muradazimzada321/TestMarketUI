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
    public class SqlCreditRepository :ICreditRepository
    {
        private readonly string connectionString;
        public SqlCreditRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool CreateCredit(Credit credit)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCredit(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadCredits()
        {
            throw new NotImplementedException();
        }

        public bool UpdateCredit(int id)
        {
            throw new NotImplementedException();
        }
    }
}
