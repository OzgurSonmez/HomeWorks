using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // Entity: Varlık (Product, Category, Employee vs.) olabilir.
    /*Generic constraint : Repository'e verilen varlığı kısıtlar.
        where T : class -> Parametre olarak sadece referans tip verilebilir.
        where T : IEntity -> IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
        new() -> new'lenebilir olmalı. (Sadece IEntity implemente eden nesnelerin seçilebilmesi sağlandı.) 
    */
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {  
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // Expression: Linq ile beraber filtreleme yapılmasını sağlar."filter=null" : filtreleme yapılması zorunlu değildir.
        T Get(Expression<Func<T, bool>> filter); // "filter" : filtre yapılması zorunludur.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);        
    }
}
