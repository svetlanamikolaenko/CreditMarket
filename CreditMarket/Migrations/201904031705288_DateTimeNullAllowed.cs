namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeNullAllowed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Orders", "PassportGivenDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "PassportGivenDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Orders", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
