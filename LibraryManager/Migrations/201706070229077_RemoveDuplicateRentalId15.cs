namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDuplicateRentalId15 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Rentals WHERE Id=15");
        }
        
        public override void Down()
        {
        }
    }
}
