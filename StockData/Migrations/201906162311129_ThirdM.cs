namespace StockData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockComponents", "Contractor", c => c.String());
            AddColumn("dbo.StockComponents", "ContractorId", c => c.Int(nullable: false));
            AddColumn("dbo.StockComponents", "DateCreate", c => c.DateTime());
            CreateIndex("dbo.StockComponents", "ContractorId");
            AddForeignKey("dbo.StockComponents", "ContractorId", "dbo.Contractors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockComponents", "ContractorId", "dbo.Contractors");
            DropIndex("dbo.StockComponents", new[] { "ContractorId" });
            DropColumn("dbo.StockComponents", "DateCreate");
            DropColumn("dbo.StockComponents", "ContractorId");
            DropColumn("dbo.StockComponents", "Contractor");
        }
    }
}
