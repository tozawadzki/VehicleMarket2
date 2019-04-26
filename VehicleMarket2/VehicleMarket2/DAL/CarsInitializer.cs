using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using VehicleMarket2.Migrations;
using VehicleMarket2.Models;


namespace VehicleMarket2.DAL
{
    public class CarsInitializer : MigrateDatabaseToLatestVersion<CarsContext, Configuration>
    {

        public static void SeedCarsData(CarsContext context)
        {
            var categories = new List<Category>
            {
                new Category() { CategoryID = 1, CategoryName = "Car", Description= "A5", Photo = "AudiA5.jpg" },
                new Category() { CategoryID = 2, CategoryName = "Bicycle", Description = "Meridka", Photo = "Merida.jpg" },
                new Category() { CategoryID = 3, CategoryName = "Motorcycle", Description = "Ninja", Photo = "Ninja.jpg" },
            };

            
            categories.ForEach(c => context.Categories.AddOrUpdate(c));
            context.SaveChanges();


            var cars = new List<Car>
            {
                new Car() { CarID=1, CategoryID=1, Brand = "Volkswagen", Model= "Passat B5", YearOfProduction= "2001", WhenAdded = DateTime.Now, Price = 8000, Supercar = false, Photo = "Passat.jpg" },
                new Car() { CarID=2, CategoryID=1, Brand = "Audi", Model= "A5", YearOfProduction= "2011", WhenAdded = DateTime.Now, Price = 40000, Supercar = false, Photo = "AudiA5.jpg" },
                new Car() { CarID=2, CategoryID = 1, Brand = "Tesla", Model = "Model S",  YearOfProduction= "2017", WhenAdded = DateTime.Now, Price = 150000, Supercar = true, Photo = "Tesla.jpg" },
                new Car() { CarID=2, CategoryID = 1, Brand = "Maserati", Model = "GranTurismo",  YearOfProduction= "2014",  WhenAdded = DateTime.Now, Price = 200000, Supercar = true, Photo = "Maserati.jpg" },
            };

            cars.ForEach(c => context.Cars.AddOrUpdate(c));
            context.SaveChanges();
        }
    }
}
