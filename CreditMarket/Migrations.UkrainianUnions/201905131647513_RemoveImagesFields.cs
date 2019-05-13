namespace CreditMarket.Migrations.UkrainianUnions
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveImagesFields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ApprovedOrders", "PassportImages");
            DropColumn("dbo.ApprovedOrders", "INNImages");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApprovedOrders", "INNImages", c => c.Binary());
            AddColumn("dbo.ApprovedOrders", "PassportImages", c => c.Binary());
        }
    }
}
