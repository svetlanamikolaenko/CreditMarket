namespace CreditMarket.Migrations.Orders
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cd20837d-f17a-4ad8-971c-bbdcd43356b3', N'admin@creditmarket.com', 0, N'AGYdVAcJRu3aGjxgHWuy+m72KCx3od3GEQW31FRJ5MJ+AWEwylbx55g1QmdG7021ng==', N'e9c9d334-6eee-4546-a8fb-b60d195b99a8', NULL, 0, 0, NULL, 1, 0, N'admin@creditmarket.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fe405bea-0a7f-40a0-bae7-ca27092399b1', N'svetlana.mikolaenko@gmail.com', 0, N'AGjWwyNjtCSTVFJ/QFIpygb+4NFryFAKj+bPPSGmfEKGthkL55q6rRDgYpShNLbFPg==', N'427ae7cf-b15e-44b8-a57b-ac6b4ee940b2', NULL, 0, 0, NULL, 1, 0, N'svetlana.mikolaenko@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ffca4902-6e52-43b4-b92b-559e06bb4df2', N'manager@creditmarket.com', 0, N'ACY/hesiGb/CGImpF3Tut2bBKmlOofJnz4fmDXwXljdYzh1o18DB/vE1Q631WNsKzQ==', N'26797585-2324-44be-a719-a69432a9c8cd', NULL, 0, 0, NULL, 1, 0, N'manager@creditmarket.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a090a6eb-50fb-4c5a-8a37-02dccf9f9bd5', N'CanManageLoans')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'138e3362-eac7-4926-aaf0-ff57b2167e86', N'CanManageOrders')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ffca4902-6e52-43b4-b92b-559e06bb4df2', N'138e3362-eac7-4926-aaf0-ff57b2167e86')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cd20837d-f17a-4ad8-971c-bbdcd43356b3', N'a090a6eb-50fb-4c5a-8a37-02dccf9f9bd5')

");
        }
        
        public override void Down()
        {
        }
    }
}
