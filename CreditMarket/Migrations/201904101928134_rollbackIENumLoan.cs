namespace CreditMarket.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class rollbackIENumLoan : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Orders", "LoanId");
            AddForeignKey("dbo.Orders", "LoanId", "dbo.Loans", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {

        }
    }
}
