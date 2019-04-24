namespace VehicleMarket2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class probaRatowania : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Car", "WhenAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Car", "Hidden", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Car", "Hidden");
            DropColumn("dbo.Car", "WhenAdded");
        }
    }
}
