namespace DVDRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTCNOColumntoTcno : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.AspNetUsers","TCNO","Tcno");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.AspNetUsers", "Tcno", "TCNO");
        }
    }
}
