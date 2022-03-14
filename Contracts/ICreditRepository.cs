using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMarketUI.Entities;

namespace TestMarketUI.Contracts
{
   public interface ICreditRepository
    {
        bool CreateCredit(Credit credit);
        DataTable ReadCredits();
        bool UpdateCredit(int id);

        bool DeleteCredit(int id);
    }
}
