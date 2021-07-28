using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Bonus
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Shipping_Address> ShipAddress { get; set; }
    }
}
