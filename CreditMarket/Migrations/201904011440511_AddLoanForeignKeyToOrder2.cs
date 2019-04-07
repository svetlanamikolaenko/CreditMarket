namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoanForeignKeyToOrder2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans");
            DropIndex("dbo.Orders", new[] { "Loan_Id" });
            AddColumn("dbo.Orders", "LoanId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Orders", "Loan_Id", c => c.Int());
            CreateIndex("dbo.Orders", "Loan_Id");
            AddForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans");
            DropIndex("dbo.Orders", new[] { "Loan_Id" });
            AlterColumn("dbo.Orders", "Loan_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "LoanId");
            CreateIndex("dbo.Orders", "Loan_Id");
            AddForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans", "Id", cascadeDelete: true);
        }
    }
}
