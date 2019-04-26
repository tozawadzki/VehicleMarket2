using VehicleMarket2.DAL;

namespace VehicleMarket2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<VehicleMarket2.DAL.CarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "VehicleMarket2.DAL.CarsContext";
        }

        protected override void Seed(VehicleMarket2.DAL.CarsContext context)
        {
            CarsInitializer.SeedCarsData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
