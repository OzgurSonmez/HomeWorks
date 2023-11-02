using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace _06_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();

            string sentence = "My name is Özgür Sönmez";

            var result1 = sentence.Length;
            Console.WriteLine(result1);     //23

            var result2 = sentence.Clone();
            Console.WriteLine(result2);     //My name is Özgür Sönmez
            sentence = "My name is Engin Demiroğ";

            bool result3 = sentence.EndsWith("ğ");
            Console.WriteLine(result3);     //True

            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);     //True

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result5);     //3
            Console.WriteLine(result6);     //2
            Console.WriteLine(result7);     //16

            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8);     //Hello, My name is Engin Demiroğ

            var result9 = sentence.Substring(3, 4);
            Console.WriteLine(result9);     //name

            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            Console.WriteLine(result10);    //my name is engin demiroğ
            Console.WriteLine(result11);    //MY NAME İS ENGİN DEMİROĞ

            var result12 = sentence.Replace(" ","-");
            Console.WriteLine(result12);    //My-name-is-Engin-Demiroğ

            var result13 = sentence.Remove(2);
            var result14 = sentence.Remove(2,5);
            Console.WriteLine(result13);    //My
            Console.WriteLine(result14);    //My is Engin Demiroğ
        }

        static void Intro()
        {
            string city = "Sinop";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}