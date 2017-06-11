namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, LateFeeRate, DurationInYears) VALUES (1, 100, 2)");
            Sql("INSERT INTO MembershipTypes (Id, LateFeeRate, DurationInYears) VALUES (2, 50, 10)");
        }
        
        public override void Down()
        {
        }
    }
}
