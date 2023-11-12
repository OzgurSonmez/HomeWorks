using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //IProductDal -> I : Interface , Product : Hangi Entity'e karşılık geldiğini gösterir, Dal: Data Access Layer veritabanında yapılacak operasyonları listeler
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); //Kategoriye göre filtreleme
    }
}
