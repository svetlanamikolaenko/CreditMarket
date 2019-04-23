namespace CreditMarket.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updateModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Amount", c => c.Double());
            AlterColumn("dbo.Orders", "FirstName", c => c.String());
            AlterColumn("dbo.Orders", "LastName", c => c.String());
            AlterColumn("dbo.Orders", "FathersName", c => c.String());
            AlterColumn("dbo.Orders", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Orders", "Email", c => c.String());
            AlterColumn("dbo.Orders", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Orders", "INN", c => c.Long());
            AlterColumn("dbo.Orders", "PassportNumber", c => c.String());
            AlterColumn("dbo.Orders", "PassportGivenByWhom", c => c.String());
            AlterColumn("dbo.Orders", "PassportGivenDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "PassportGivenDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "PassportGivenByWhom", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Orders", "PassportNumber", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Orders", "INN", c => c.Long(nullable: false));
            AlterColumn("dbo.Orders", "PhoneNumber", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Orders", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "FathersName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "Amount", c => c.Double(nullable: false));
        }
    }
}
