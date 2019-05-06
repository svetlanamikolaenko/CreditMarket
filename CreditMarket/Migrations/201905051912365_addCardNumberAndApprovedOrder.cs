namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCardNumberAndApprovedOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "CardNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "CardNumber");
        }
    }
}
