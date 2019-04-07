namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoanForeignKeyToOrder3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Orders", name: "Loan_Id", newName: "LoanId");
            RenameIndex(table: "dbo.Orders", name: "IX_Loan_Id", newName: "IX_LoanId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Orders", name: "IX_LoanId", newName: "IX_Loan_Id");
            RenameColumn(table: "dbo.Orders", name: "LoanId", newName: "Loan_Id");
        }
    }
}
