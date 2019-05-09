namespace CreditMarket.Migrations.UkrainianUnions
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateApprovedOrders : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApprovedOrders", "LoanPeriod", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApprovedOrders", "LoanPeriod", c => c.Int(nullable: false));
        }
    }
}
