namespace StockData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockComponents", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.StockComponents", "ProductName", c => c.String());
            CreateIndex("dbo.StockComponents", "ProductId");
            AddForeignKey("dbo.StockComponents", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockComponents", "ProductId", "dbo.Products");
            DropIndex("dbo.StockComponents", new[] { "ProductId" });
            DropColumn("dbo.StockComponents", "ProductName");
            DropColumn("dbo.StockComponents", "ProductId");
        }
    }
}
