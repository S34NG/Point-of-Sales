using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Point_of_Sales.Model
{
    public partial class PosDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public PosDbContext()
        {
        }

        public PosDbContext(DbContextOptions<PosDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddUserSecrets<PosDbContext>().Build();
                var secretProvider = config.Providers.First();
                //optionsBuilder.UseSqlServer(Configuration);
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=POS.mdf;Integrated Security=True;Connect Timeout=30");
                if (secretProvider.TryGet("PosDb", out var PosDb))
                {
                    PosDb = String.Format(PosDb,Environment.CurrentDirectory);
                    //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Work\2022\FT_SD_E_13\TermProject\PointofSales\POS.mdf;Integrated Security=True;Connect Timeout=30
                    //Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\Work\2022\FT_SD_E_13\TermProject\PointofSales\POS.mdf;Integrated Security=True;Connect Timeout=30
                    Console.WriteLine("PosDb: "+PosDb);
                    optionsBuilder.UseSqlServer(PosDb);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
