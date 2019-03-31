namespace CreditMarket.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class AddLoans : DbMigration
	{
		public override void Up()
		{
			Sql("INSERT INTO LOANS (Name, Period, Procent) VALUES ('Month', 1, 1)");
			Sql("INSERT INTO LOANS (Name, Period, Procent) VALUES ('HalfYear', 6, 5)");
			Sql("INSERT INTO LOANS (Name, Period, Procent) VALUES ('Year', 12, 10)");
		}
		
		public override void Down()
		{
			Sql("DELETE FROM LOANS WHERE Id IN (1, 2, 3)");
		}
	}
}
