using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04_YGYK_04_OOP_1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // foreign key
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
