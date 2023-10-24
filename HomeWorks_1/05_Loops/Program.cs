using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {                  
            ForLoop();
            WhileLoop();
            DoWhileLoop();
            ForEachLoop();

            if (IsPrimeNumber(7))
                Console.WriteLine("This is a prime number");
            else Console.WriteLine("This is not a prime number");
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++) 
            { 
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }

        static void ForLoop()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");
        }

        static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }
        static void DoWhileLoop()
        {           
            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;
            } while (number2 >= 0);
        }
        static void ForEachLoop()
        {
            string[] students1 = new string[3] { "Özgür", "Tufan", "Burak" };
            foreach (var student in students1)
            {
                Console.WriteLine(student);
            }
        }

    }
}