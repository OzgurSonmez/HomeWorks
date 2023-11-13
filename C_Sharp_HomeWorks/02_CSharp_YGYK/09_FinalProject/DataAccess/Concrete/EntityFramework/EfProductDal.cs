using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet: C#'ın .Net içerisindeki implementasyonlarını kullandık, başka insanların yazdığı kodları paket halinde aldığımız ortam
    //DataAccess -> Manage NuGet Packages... -> "entityframeworkcore.sql" ile EntityFrameWork eklendi
    
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            // using bloğu: blok bittikten hemen sonra parametredeki değeri bellekten siler, bellekte yer kaplamaz
            // IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakala
                addedEntity.State = EntityState.Added;  //Yapılacak işlem
                context.SaveChanges(); // Kaydet
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); //Referansı yakala
                deletedEntity.State = EntityState.Deleted;  //Yapılacak işlem
                context.SaveChanges(); // Kaydet
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); // filtreye göre product döndürür
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //context.Set<Product>().ToList() -> Select * From Products döndürür.
                return filter == null
                    ? context.Set<Product>().ToList() // Filte yoksa tüm tabloyu döner
                    : context.Set<Product>().Where(filter).ToList(); // Filtre varsa filtreleyip döner
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var UpdatedEntity = context.Entry(entity); //Referansı yakala
                UpdatedEntity.State = EntityState.Modified;  //Yapılacak işlem
                context.SaveChanges(); // Kaydet
            }
        }
    }
}
