namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Standard' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Senior' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
