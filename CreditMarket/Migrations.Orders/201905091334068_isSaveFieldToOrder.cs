namespace CreditMarket.Migrations.Orders
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isSaveFieldToOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsSaved", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "IsSaved");
        }
    }
}
