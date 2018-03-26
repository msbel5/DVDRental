namespace DVDRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedEmployee : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5272f1c-cc2d-40d4-82e0-e85d09534300', N'employee@dvdrental.com', 0, N'AOliddesVSc7cYrSgiz4ATbtQxKPa/jJsR4tMkP8Jxo1vFOLec+iUMhPEqz+7qvoAA==', N'998d07bb-06dd-47a7-8bea-498c0ee74877', NULL, 0, 0, NULL, 1, 0, N'employee@dvdrental.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a717a4b1-c703-472b-ac16-12f7d6225953', N'CanManageCustomers')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5272f1c-cc2d-40d4-82e0-e85d09534300', N'a717a4b1-c703-472b-ac16-12f7d6225953')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
