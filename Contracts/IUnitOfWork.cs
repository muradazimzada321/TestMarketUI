using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketUI.Contracts
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        ICreditRepository CreditRepository { get; }
        IPaymentRepository PaymentRepository { get;  }

    }
}
