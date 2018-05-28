namespace TradingSignalAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifySignalModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Signals", "ClosePrice", c => c.Double());
            AlterColumn("dbo.Signals", "Profit", c => c.Double());
            AlterColumn("dbo.Signals", "OpenTime", c => c.DateTime());
            AlterColumn("dbo.Signals", "CloseTime", c => c.DateTime());
            AlterColumn("dbo.Signals", "Expire", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Signals", "Expire", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Signals", "CloseTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Signals", "OpenTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Signals", "Profit", c => c.Double(nullable: false));
            AlterColumn("dbo.Signals", "ClosePrice", c => c.Double(nullable: false));
        }
    }
}
