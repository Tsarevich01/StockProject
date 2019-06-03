namespace StockDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockComponents", "UnitId", c => c.Int(nullable: false));
            AddColumn("dbo.StockComponents", "UnitName", c => c.String());
            CreateIndex("dbo.StockComponents", "UnitId");
            AddForeignKey("dbo.StockComponents", "UnitId", "dbo.Units", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockComponents", "UnitId", "dbo.Units");
            DropIndex("dbo.StockComponents", new[] { "UnitId" });
            DropColumn("dbo.StockComponents", "UnitName");
            DropColumn("dbo.StockComponents", "UnitId");
        }
    }
}
