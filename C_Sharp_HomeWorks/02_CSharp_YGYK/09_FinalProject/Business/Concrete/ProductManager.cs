using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //Soyut sınıfla bağlantı kurmalıyız
        IProductDal _productDal;

        public ProductManager(IProductDal productDal) //Veri erişim teknolojilerinden herhangi biri olabilir 
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları 
            //Bir iş sınıfı başka class'ları new'lemez !

            return _productDal.GetAll();

        }
    }
}
