// See https://aka.ms/new-console-template for more information
using _12_YGYK_Methods;

/*
 *  https://www.youtube.com/watch?v=1j68gb1-qOw&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=3 
 *  Yazılım Geliştirici Yetiştirme Kampı 3. Gün C# Temelleri 2
 */


// Dont repeat yourself, DRY, Clean Code, Best Practice

Product product1 = new Product();
product1.Name = "Elma";
product1.Price = 15;
product1.Description = "Amasya elması";

Product product2 = new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır karpuzu";

Product[] products = new Product[] { product1, product2 };

//Type safe 
foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("-----------------------");
}

Console.WriteLine("------------ Methods ------------");

BasketManager basketManager = new BasketManager();
basketManager.Add(product1);
basketManager.Add(product1);
basketManager.Add(product2);
basketManager.Add(product2);

basketManager.Add2("Armut", "Yeşil armut", 12, 10);
basketManager.Add2("Elma", "Yeşil elma", 20, 15);
basketManager.Add2("Karpuz", "Diyarbakır karpuzu", 88, 20);