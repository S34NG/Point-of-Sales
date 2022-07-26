using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Back_end
{
    public class POSDBContext: DbContext
    {
        private static readonly string DBPath;
        static POSDBContext()
        {
            string path = @"D:\Work\2022\FT_SD_E_13\TermProject\PointofSales\POSDb.mdf";
            path = Environment.CurrentDirectory;
            if (path.Contains(@"\bin\"))
            {
                path = path.Substring(0, path.IndexOf(@"\bin\"));
            }
            path = path + @"\POSDb.mdf";
            Console.WriteLine(path);
            DBPath = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={path};Integrated Security=True;Connect Timeout=30";

        }
        public POSDBContext() : base(DBPath)
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
