namespace VehicleMarket2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        CarID = c.Int(nullable: false, identity: true),
                        CategoryID = c.Int(nullable: false),
                        Brand = c.String(nullable: false, maxLength: 100),
                        Model = c.String(nullable: false, maxLength: 100),
                        YearOfProduction = c.String(),
                        Photo = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Supercar = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CarID)
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 100),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.OrderPosition",
                c => new
                    {
                        OrderPositionID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        CarID = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        OrderPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderPositionID)
                .ForeignKey("dbo.Car", t => t.CarID, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.CarID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Surname = c.String(nullable: false, maxLength: 100),
                        Street = c.String(nullable: false, maxLength: 100),
                        PostalCode = c.String(nullable: false, maxLength: 7),
                        City = c.String(),
                        TelephoneNumber = c.String(),
                        Email = c.String(),
                        Comment = c.String(),
                        Date = c.DateTime(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderPosition", "OrderID", "dbo.Order");
            DropForeignKey("dbo.OrderPosition", "CarID", "dbo.Car");
            DropForeignKey("dbo.Car", "CategoryID", "dbo.Category");
            DropIndex("dbo.OrderPosition", new[] { "CarID" });
            DropIndex("dbo.OrderPosition", new[] { "OrderID" });
            DropIndex("dbo.Car", new[] { "CategoryID" });
            DropTable("dbo.Order");
            DropTable("dbo.OrderPosition");
            DropTable("dbo.Category");
            DropTable("dbo.Car");
        }
    }
}
