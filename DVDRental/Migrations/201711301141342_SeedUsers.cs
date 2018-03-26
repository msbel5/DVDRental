namespace DVDRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6e4c0e43-015f-45af-a77b-6d8245b63b36', N'guest@dvdrental.com', 0, N'AAhL4uknjMn7ITh8wtMLbq7HZebmkjrtrvNBw+7CVspbF+GOJatE/cdAn5eTfibyfQ==', N'0caec74a-c5ec-4cc4-a655-49e7a9269842', NULL, 0, 0, NULL, 1, 0, N'guest@dvdrental.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b14f4460-6371-43a6-8f5c-5379ec34f495', N'admin@dvdrental.com', 0, N'AMhWiDXXsE63/m/pzDDpIpuyqB7spUW+SsbGuTwzi5a3aVGtdGgzZWBeSXUtzPJzTA==', N'8e07aad2-4fa9-46b7-8b60-d8fc5e931ac9', NULL, 0, 0, NULL, 1, 0, N'admin@dvdrental.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'03a5b9d3-0d44-4d95-8f1d-f8dc802c9480', N'CanManageMovies')


                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b14f4460-6371-43a6-8f5c-5379ec34f495', N'03a5b9d3-0d44-4d95-8f1d-f8dc802c9480')

            ");
        }

        public override void Down()
        {
        }
    }
}
