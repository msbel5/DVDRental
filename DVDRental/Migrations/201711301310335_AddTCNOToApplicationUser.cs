namespace DVDRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTcnoToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "TCNO", c => c.String(nullable: false, maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "TCNO");
        }
    }
}
