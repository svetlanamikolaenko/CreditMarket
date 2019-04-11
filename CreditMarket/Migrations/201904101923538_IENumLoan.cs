namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IENumLoan : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "LoanId", "dbo.Loans");
            DropIndex("dbo.Orders", new[] { "LoanId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Orders", "LoanId");
            AddForeignKey("dbo.Orders", "LoanId", "dbo.Loans", "Id", cascadeDelete: true);
        }
    }
}
