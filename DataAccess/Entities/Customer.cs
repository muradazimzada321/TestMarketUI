using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketUI.Entities
{
    public class Customer
    {
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FIN { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public DateTime SignUpDate { get; set; }

    }
}
