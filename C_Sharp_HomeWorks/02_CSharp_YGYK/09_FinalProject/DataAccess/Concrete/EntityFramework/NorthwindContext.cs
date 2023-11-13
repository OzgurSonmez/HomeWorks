using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    // Context : Veritabanı tabloları ile proje entity'lerini bağlamak
    // DbContext : EntityFramework ile gelir
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bu method projenin hangi veritabanı ile ilişkili olduğunu belirler
            //"override on" yazınca gelir
            optionsBuilder.UseSqlServer(@"Server=(DESKTOP-MKBD3B2);Database=Northwind;Trusted_Connection=true"); // SQL server kullanılacağını belirtir ve database seçimi yapılır."Trusted_Connection=true" ile şifre istenmedi. 
            
        }
        
        // DbSet : Entity'ler ile veritabanındaki tabloları eşler.
        public DbSet<Product> Products { get; set; } // Product entity'si veritabanındaki "Products" tablosuna karşılık gelir.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
