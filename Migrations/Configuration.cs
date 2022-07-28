namespace Point_of_Sales.Migrations
{
    using Point_of_Sales.Back_end;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Point_of_Sales.Back_end.POSDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Point_of_Sales.Back_end.POSDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //User user = new User
            //{
            //    Id = 2,
            //    Name = "seang",
            //    Password = "123456",
            //    Confirm_Password = "123456",
            //    Profile = "Former pirate cruise."
            //};
            //User admin = new User
            //{
            //    Id = 1,
            //    Name = "admin",
            //    Password = "123456",
            //    Confirm_Password = "123456",
            //    Profile = "Former pirate boss."
            //};
            //User cashier = new User
            //{
            //    Id = 3,
            //    Name = "samnang",
            //    Password = "123456",
            //    Confirm_Password = "123456",
            //    Profile = "Latter pirate boss",
            //    Email = "neat814@gmail.com",
            //};
            //context.Users.Add(admin);
            //context.Users.Add(user);
            //context.Users.Add(cashier);
            //context.SaveChanges();
        }
    }
}
