// See https://aka.ms/new-console-template for more information

/*
 * https://www.youtube.com/watch?v=G0sOB_-WkyI&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=4
 * Yazılım Geliştirici Yetiştirme Kampı 4. Gün
 */

using _12_04_YGYK_04_OOP_1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product {
    Id = 2,
    CategoryId = 5,
    UnitsInStock = 5,
    UnitPrice = 35,
    ProductName = "Kalem"    
};

ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Update(product2);
