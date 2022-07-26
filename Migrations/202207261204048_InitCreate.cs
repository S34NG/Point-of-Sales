namespace Point_of_Sales.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost_Price = c.Double(nullable: false),
                        Sell_Price = c.Double(nullable: false),
                        Unit = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total_Price = c.Double(nullable: false),
                        Supplier_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Supplier_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Confirm_Password = c.String(),
                        Profile = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchse_Detail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Total_Price = c.Double(nullable: false),
                        DatePurchase = c.DateTime(nullable: false),
                        Product_Id = c.Int(),
                        Purchase_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.Sale_Detail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Total_Price = c.Double(nullable: false),
                        Date_Sale = c.DateTime(nullable: false),
                        Product_Id = c.Int(),
                        Sale_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Sales", t => t.Sale_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Sale_Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total_Price = c.Double(nullable: false),
                        Customer_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Unit = c.String(),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Sale_Detail", "Sale_Id", "dbo.Sales");
            DropForeignKey("dbo.Sales", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Sales", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Sale_Detail", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Purchse_Detail", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.Purchse_Detail", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Purchases", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Purchases", "Supplier_Id", "dbo.Suppliers");
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Stocks", new[] { "Product_Id" });
            DropIndex("dbo.Sales", new[] { "User_Id" });
            DropIndex("dbo.Sales", new[] { "Customer_Id" });
            DropIndex("dbo.Sale_Detail", new[] { "Sale_Id" });
            DropIndex("dbo.Sale_Detail", new[] { "Product_Id" });
            DropIndex("dbo.Purchse_Detail", new[] { "Purchase_Id" });
            DropIndex("dbo.Purchse_Detail", new[] { "Product_Id" });
            DropIndex("dbo.Purchases", new[] { "User_Id" });
            DropIndex("dbo.Purchases", new[] { "Supplier_Id" });
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropTable("dbo.Stocks");
            DropTable("dbo.Sales");
            DropTable("dbo.Sale_Detail");
            DropTable("dbo.Purchse_Detail");
            DropTable("dbo.Users");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Purchases");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
