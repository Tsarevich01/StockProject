namespace StockData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contractors", "Phone", c => c.Int(nullable: false));
            DropColumn("dbo.Contractors", "Tel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contractors", "Tel", c => c.Int(nullable: false));
            DropColumn("dbo.Contractors", "Phone");
        }
    }
}
