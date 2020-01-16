namespace AirlineMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAirport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(nullable: false),
                        Street = c.String(),
                        Town = c.String(),
                        County = c.Int(nullable: false),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        AirportID = c.String(nullable: false, maxLength: 128),
                        AirportName = c.String(),
                        NearestCity = c.String(),
                        CountryCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AirportID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        TelephoneNo = c.String(),
                        AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Addresses", t => t.AddressID)
                .Index(t => t.AddressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "AddressID", "dbo.Addresses");
            DropIndex("dbo.Customers", new[] { "AddressID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Airports");
            DropTable("dbo.Addresses");
        }
    }
}
