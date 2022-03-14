using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMarketUI.Entities;

namespace TestMarketUI.Contracts
{
    public interface ICustomerRepository
    {
        bool CreateCustomer(Customer customer);
        DataTable ReadCustomers();
        bool UpdateCustomer(int id);
        bool DeleteCustomer(int id);

    }
}
