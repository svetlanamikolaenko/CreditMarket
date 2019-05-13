namespace CreditMarket.Migrations.Orders
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveImagesFields2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Loans", "Procent", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Loans", "Procent", c => c.Double(nullable: false));
        }
    }
}
