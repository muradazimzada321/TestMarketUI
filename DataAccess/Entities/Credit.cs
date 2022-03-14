using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketUI.Entities
{
    public class Credit
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        public int Date { get; set; }
    }

}
