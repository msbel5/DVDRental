namespace DVDRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DobToBirthDateChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime());
            DropColumn("dbo.Customers", "DoB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DoB", c => c.DateTime());
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
