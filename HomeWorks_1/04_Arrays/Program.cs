namespace _04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students1 = new string[3]{ "Özgür", "Tufan", "Burak" }; 
            string[] students2 = new[]{"Özgür" ,"Tufan" ,"Burak"};
            string[] students3 = {"Özgür", "Tufan", "Burak" };

            foreach (var s in students3) 
            { 
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // Multi Dimensional Array

            string[,] regions = new string[7, 3]
                {
                    {"İstanbul", "İzmit", "Bursa"},
                    {"Ankara", "Konya", "Kırıkkale"},
                    {"Antalya", "Adana", "Mersin"},
                    {"Sinop", "Samsun", "Trabzon"},
                    {"İzmir", "Muğla", "Manisa"},
                    {"Van", "Iğdır", "Kars"},
                    {"Şanlıurfa", "Diyarbakır", "Mardin"}
                };
            for (int i = 0; i <= regions.GetUpperBound(0); i++) 
            { 
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***************");
            }            
        }
    }
}