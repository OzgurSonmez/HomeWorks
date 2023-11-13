/*
 * * https://www.youtube.com/watch?v=qBQOqh844Mo&list=PLqG356ExoxZVN7rC0KmMo0lvECK97VRZg&index=7
 * Yazılım Geliştirici Yetiştirme Kampı 7. Gün C# 
 */


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAllByCategoryId(2))
{
    Console.WriteLine(product.ProductName);
}
