namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INNField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "INN", c => c.Long());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "INN", c => c.Long(nullable: false));
        }
    }
}
