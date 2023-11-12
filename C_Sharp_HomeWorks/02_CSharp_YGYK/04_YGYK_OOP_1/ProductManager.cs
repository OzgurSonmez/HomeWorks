using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_04_YGYK_04_OOP_1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }
}
