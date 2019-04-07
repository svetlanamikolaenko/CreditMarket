 namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "FirstName", c => c.String());
            AlterColumn("dbo.Orders", "LastName", c => c.String());
            AlterColumn("dbo.Orders", "FathersName", c => c.String());
            AlterColumn("dbo.Orders", "Email", c => c.String());
            AlterColumn("dbo.Orders", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Orders", "PassportNumber", c => c.String());
            AlterColumn("dbo.Orders", "PassportGivenByWhom", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "PassportGivenByWhom", c => c.String(nullable: false, maxLength: 120));
            AlterColumn("dbo.Orders", "PassportNumber", c => c.String(nullable: false, maxLength: 8));
            AlterColumn("dbo.Orders", "PhoneNumber", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Orders", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Orders", "FathersName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "FirstName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
