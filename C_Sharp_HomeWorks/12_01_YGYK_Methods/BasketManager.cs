using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_YGYK_Methods
{
     class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + product.Name);
        }

        public void Add2(string ProductName, string ProductDescription, double ProductPrice, int StockQuantity) 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + ProductName);
        }
    }
}
