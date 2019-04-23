namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmountField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Amount", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Amount", c => c.Double(nullable: false));
        }
    }
}
