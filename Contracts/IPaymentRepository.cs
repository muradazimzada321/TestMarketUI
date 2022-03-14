using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMarketUI.Entities;

namespace TestMarketUI.Contracts
{
    public interface IPaymentRepository
    {
        bool CreatePayment(Credit credit);

        DataTable ReadPayments();
        bool UpdatePayment(int id);

        bool DeletePayments(int id);
    }
}
