namespace CreditMarket.Migrations.UkrainianUnions
{
    using System.Data.Entity.Migrations;

    public partial class PopulateData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT ApprovedOrders ON");

            Sql("INSERT INTO ApprovedOrders(Id, LoanPeriod, UnionName, Amount, FirstName, LastName, FathersName, DateOfBirth, Email, PhoneNumber, CardNumber, INN, PassportNumber, PassportGivenByWhom, PassportGivenDate, ApprovedDate) VALUES (150, 12, 'CreditMark', 50000, 'Ivan', 'Ivanov', 'Ivanovich', '2001-05-01 00:00:00', 'test@test.test', '7897789', '12345689', '456456', '456', 'adsadqwe','2019-05-01 00:00:00', '2019-05-06 00:00:00')");

            Sql("SET IDENTITY_INSERT ApprovedOrders OFF");
        }
        
        public override void Down()
        {
        }
    }
}
