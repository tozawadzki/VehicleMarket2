namespace VehicleMarket2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propertyDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Car", "Description");
        }
    }
}
