using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    //InMemoryProductDal -> InMemory : Teknolojinin adı , Product : Hangi Entity'e karşılık geldiğini gösterir, Dal: Data Access Layer veritabanında yapılacak operasyonları listeler
    // Data Access kodlarının yazılacağı yer
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // Global değişkenler _ ile başlayarak isimlendirilir.
        public InMemoryProductDal() //Class'ın ismi ile aynı olunca constructor olur
        {
            //Oracle, SQL Server, Postgres, MongoDB gibi bir veritabanından geliyormuş gibi simüle ediyoruz
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1, ProductName= "Bardak", UnitPrice = 15, UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1, ProductName= "Kamera", UnitPrice = 500, UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2, ProductName= "Telefon", UnitPrice = 1500, UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2, ProductName= "Klavye", UnitPrice = 150, UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2, ProductName= "Fare", UnitPrice = 85, UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query            
            //Linq'siz bu şekilde kullanılırdı
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //Gönderdiğim productId ye sahip productın refaransını bul.
            //First(), FirstOrDefauly() da kullanılabilirdi.
            //Bu sorgu sonununca 2 eleman gelirse hata verir.
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //Where: İçindeki şarta uyan bütün elemanları yeni bir liste haline getirerek döndürür
            //Koşul sayısı artabilir && ile
            return _products.Where(p => p.CategoryId == categoryId).ToList();            
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);//Gönderdiğim productId ye sahip productın refaransını bul.
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
