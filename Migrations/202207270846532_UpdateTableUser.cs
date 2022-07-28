namespace Point_of_Sales.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTableUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "Pin", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Pin");
            DropColumn("dbo.Users", "Email");
        }
    }
}
