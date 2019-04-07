namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationDbContextUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "PassportImages", c => c.Binary());
            AlterColumn("dbo.Orders", "INNImages", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "INNImages", c => c.Binary(nullable: false));
            AlterColumn("dbo.Orders", "PassportImages", c => c.Binary(nullable: false));
        }
    }
}
