using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Bonus
{
    class Customer_Order
    {
        public string OrderId { get; set; }
        public int MyProperty { get; set; }
        public List<Customer> Order { get; set; }
        public List<LineItems> Items { get; set; }

    }
}
