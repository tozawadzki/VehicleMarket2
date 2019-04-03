using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VehicleMarket2.Models;

namespace VehicleMarket2.DAL
{
    public class CarsInitializer : DropCreateDatabaseAlways<CarsContext>
    {
        protected override void Seed(CarsContext context)
        {
            SeedCarsData(context);
            base.Seed(context);
        }

        private void SeedCarsData(CarsContext context)
        {
            var categories = new List<Category>
            {
                 new Category() { CategoryID=1, CategoryName = "Car", Description= "Volkswagen Passat B5", Photo = "AudiA5.jpg" },
            new Category() { CategoryID = 2, CategoryName = "Bicycle", Description = "Audi A5", Photo = "Merida.jpg" },
            new Category() { CategoryID = 3, CategoryName = "Motorcycle", Description = "Mazda RX-8", Photo = "Ninja.jpg" },
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var cars = new List<Car>
            {
                new Car() { CarID=1, CategoryID=1, Brand = "Volkswagen", Model= "Passat B5", YearOfProduction= "2001", Price = 8000, Supercar = false, Photo = "Passat.jpg" },
                new Car() { CarID=2, CategoryID=1, Brand = "Audi", Model= "A5", YearOfProduction= "2011", Price = 40000, Supercar = false, Photo = "AudiA5.jpg" },
                new Car() { CarID=2, CategoryID = 1, Brand = "Tesla", Model = "Model S",  YearOfProduction= "2017", Price = 150000, Supercar = true, Photo = "Tesla.jpg" },
                new Car() { CarID=2, CategoryID = 1, Brand = "Maserati", Model = "GranTurismo",  YearOfProduction= "2014", Price = 200000, Supercar = true, Photo = "Maserati.jpg" },
            };

            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();
        }
        }
    }
