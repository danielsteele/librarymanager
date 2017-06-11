namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChildMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Name, LateFeeRate, DurationInYears) VALUES (3, 'Child', 50, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
