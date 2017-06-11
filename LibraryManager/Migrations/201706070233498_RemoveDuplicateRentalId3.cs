namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDuplicateRentalId3 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Rentals WHERE Id=3");
        }
        
        public override void Down()
        {
        }
    }
}
