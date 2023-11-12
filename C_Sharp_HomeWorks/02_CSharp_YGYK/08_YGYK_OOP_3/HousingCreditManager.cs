using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_08_YGYK_OOP_3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
