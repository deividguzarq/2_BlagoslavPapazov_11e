namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class h8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        YIncome = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Seats = c.Int(nullable: false),
                        Tickets = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FlightId = c.Int(nullable: false),
                        Airport_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .ForeignKey("dbo.Airports", t => t.Airport_Id)
                .Index(t => t.FlightId)
                .Index(t => t.Airport_Id);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Destination = c.String(nullable: false, maxLength: 30),
                        Time = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Airport_Id", "dbo.Airports");
            DropForeignKey("dbo.Reservations", "FlightId", "dbo.Flights");
            DropIndex("dbo.Reservations", new[] { "Airport_Id" });
            DropIndex("dbo.Reservations", new[] { "FlightId" });
            DropTable("dbo.Flights");
            DropTable("dbo.Reservations");
            DropTable("dbo.Airports");
        }
    }
}
