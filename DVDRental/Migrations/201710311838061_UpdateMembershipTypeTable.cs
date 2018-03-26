namespace DVDRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay as You Go' where Id=1");
            Sql("UPDATE MembershipTypes SET Name='Montly' where Id=2");
            Sql("UPDATE MembershipTypes SET Name='Quarterly' where Id=3");
            Sql("UPDATE MembershipTypes SET Name='Annualy' where Id=4");
            AlterColumn("dbo.MembershipTypes","Name",c=>c.String(nullable:false));
        }
        
        public override void Down()
        {
        }
    }
}
