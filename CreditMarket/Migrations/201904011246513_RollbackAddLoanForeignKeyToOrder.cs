namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RollbackAddLoanForeignKeyToOrder : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans");
            DropIndex("dbo.Orders", new[] { "Loan_Id" });
            AlterColumn("dbo.Orders", "Loan_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "Loan_Id");
            AddForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans", "Id", cascadeDelete: true);
            DropColumn("dbo.Orders", "LoanId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "LoanId", c => c.Byte(nullable: false));
            DropForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans");
            DropIndex("dbo.Orders", new[] { "Loan_Id" });
            AlterColumn("dbo.Orders", "Loan_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Loan_Id");
            AddForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans", "Id");
        }
    }
}
