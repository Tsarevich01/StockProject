namespace StockDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComponentName = c.String(nullable: false),
                        Barcode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductComponents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComponentId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Components", t => t.ComponentId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ComponentId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockComponents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockId = c.Int(nullable: false),
                        ComponentId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Barcode = c.Int(nullable: false),
                        Sum = c.Int(nullable: false),
                        SumInNds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Components", t => t.ComponentId, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.StockId, cascadeDelete: true)
                .Index(t => t.StockId)
                .Index(t => t.ComponentId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractorName = c.String(nullable: false),
                        Code = c.Int(nullable: false),
                        UrAdres = c.String(nullable: false),
                        Tel = c.Int(nullable: false),
                        ContractorEmail = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonFIO = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockComponents", "StockId", "dbo.Stocks");
            DropForeignKey("dbo.StockComponents", "ComponentId", "dbo.Components");
            DropForeignKey("dbo.ProductComponents", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductComponents", "ComponentId", "dbo.Components");
            DropIndex("dbo.StockComponents", new[] { "ComponentId" });
            DropIndex("dbo.StockComponents", new[] { "StockId" });
            DropIndex("dbo.ProductComponents", new[] { "ProductId" });
            DropIndex("dbo.ProductComponents", new[] { "ComponentId" });
            DropTable("dbo.Units");
            DropTable("dbo.People");
            DropTable("dbo.Contractors");
            DropTable("dbo.Stocks");
            DropTable("dbo.StockComponents");
            DropTable("dbo.Products");
            DropTable("dbo.ProductComponents");
            DropTable("dbo.Components");
        }
    }
}
