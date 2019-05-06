namespace CreditMarket.Migrations.UkrainianUnions
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialApprovedOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApprovedOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoanPeriod = c.Int(nullable: false),
                        UnionName = c.String(),
                        Amount = c.Double(),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        FathersName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(),
                        Email = c.String(maxLength: 50),
                        PhoneNumber = c.String(maxLength: 12),
                        CardNumber = c.Long(),
                        INN = c.Long(),
                        PassportNumber = c.String(maxLength: 8),
                        PassportGivenByWhom = c.String(maxLength: 120),
                        PassportGivenDate = c.DateTime(),
                        PassportImages = c.Binary(),
                        INNImages = c.Binary(),
                        ApprovedDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApprovedOrders");
        }
    }
}
