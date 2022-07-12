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
        public POSDBContext() : base("Data Source=DESKTOP-N1CF1RE;Initial Catalog=POSProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
