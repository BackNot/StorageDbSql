using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Objects;

namespace Storage
{
   public class StorageDbContext : DbContext
    {
       public StorageDbContext()
           : base("name=StorageDbConnString")
       {

       }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           Database.SetInitializer<StorageDbContext>(new CreateDatabaseIfNotExists<StorageDbContext>());
           base.OnModelCreating(modelBuilder);
       }

       public DbSet<Item> Items { get; set; }
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Purchase> Purchases { get; set; }
   }
}
