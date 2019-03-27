using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VehicleMarket2.Models;

namespace VehicleMarket2.DAL
{
    public class CarsContext : DbContext
    {
        public CarsContext() : base("CarsContext")
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderPosition> OrderPositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Neutralizuje automatyczne dodawnie s do liczby mnogiej
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}