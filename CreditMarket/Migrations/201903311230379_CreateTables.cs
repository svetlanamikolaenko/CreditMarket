namespace CreditMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Period = c.Int(nullable: false),
                        Procent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        FathersName = c.String(nullable: false, maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 12),
                        INN = c.Long(nullable: false),
                        PassportNumber = c.String(nullable: false, maxLength: 8),
                        PassportGivenByWhom = c.String(nullable: false, maxLength: 120),
                        PassportGivenDate = c.DateTime(nullable: false),
                        PassportImages = c.Binary(nullable: false),
                        INNImages = c.Binary(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        ApprovedDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                        Loan_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Loans", t => t.Loan_Id, cascadeDelete: true)
                .Index(t => t.Loan_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Loan_Id", "dbo.Loans");
            DropIndex("dbo.Orders", new[] { "Loan_Id" });
            DropTable("dbo.Orders");
            DropTable("dbo.Loans");
        }
    }
}
