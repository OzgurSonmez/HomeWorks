namespace _03_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            Add();

            var result1 = Add2(5, 10);
            Console.WriteLine(result1);
            var result2 = Add2(5);
            Console.WriteLine(result2);

            /***********************************/
            int number1 = 20;
            int number2;
            var result3 = Add3(ref number1, out number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            /***********************************/
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4,10));

            /***********************************/
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //Default parameter
        static int Add2(int number1, int number2 = 30)
        {
            return number1 + number2;
        }

        //Ref, out Keyword
        static int Add3(ref int number1, out int number2)
        {
            number1 = 30;
            number2 = 100;
            return (number1 + number2);
        }

        //Method Overloading

        static int Multiply(int number1, int number2)
        {
            return (number1 * number2);
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return (number1 * number2 * number3);
        }

        // Params Keyword
        static int Add4(int number, params int[] numbers) 
        {
            return numbers.Sum();       
        }
    }
}