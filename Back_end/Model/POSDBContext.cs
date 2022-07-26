using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Back_end
{
    internal class POSDBContext: DbContext
    {
        public POSDBContext() : base(@"Data Source=LAPTOP-GKBVNMH4\SQLDEV19;Initial Catalog=POSProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Sale_Detail> Sale_Details { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public  DbSet<Purchse_Detail> Purchse_Details { get; set; }
        public DbSet<Stock> Stocks { get; set; }

    }
}
