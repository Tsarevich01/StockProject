namespace StockData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockComponents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockComponents", "ContractorId", c => c.Int(nullable: false));
            AddColumn("dbo.StockComponents", "DateCreate", c => c.DateTime());
            AlterColumn("dbo.Contractors", "Phone", c => c.String(nullable: false));
            CreateIndex("dbo.StockComponents", "ContractorId");
            AddForeignKey("dbo.StockComponents", "ContractorId", "dbo.Contractors", "Id", cascadeDelete: true);
            DropColumn("dbo.StockComponents", "ProductName");
            DropColumn("dbo.StockComponents", "UnitName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StockComponents", "UnitName", c => c.String());
            AddColumn("dbo.StockComponents", "ProductName", c => c.String());
            DropForeignKey("dbo.StockComponents", "ContractorId", "dbo.Contractors");
            DropIndex("dbo.StockComponents", new[] { "ContractorId" });
            AlterColumn("dbo.Contractors", "Phone", c => c.Int(nullable: false));
            DropColumn("dbo.StockComponents", "DateCreate");
            DropColumn("dbo.StockComponents", "ContractorId");
        }
    }
}
