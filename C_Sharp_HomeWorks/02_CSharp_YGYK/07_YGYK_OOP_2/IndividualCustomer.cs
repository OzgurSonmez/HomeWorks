using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_07_YGYK_OOP_2
{
    //Bireysel - Gerçek Müşteri
    class IndividualCustomer : Customer
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
