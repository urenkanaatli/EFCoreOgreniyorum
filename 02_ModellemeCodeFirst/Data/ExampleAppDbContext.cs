using _02_ModellemeCodeFirst.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModellemeCodeFirst.Data
{

    //Database sınıfının ef core tarafından sağlanan DbContext sınıfından base alması yeterlidir.
    public class ExampleAppDbContext : DbContext
    {

        //dbset<T>  tablolarındır.
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExampleApp;Trusted_Connection=True;TrustServerCertificate=True;");
            // sen sql servera gideceksin ve connection strgind de sudur.
            //.....
            //...
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
