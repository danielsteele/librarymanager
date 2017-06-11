namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectBirthDateForCustomer1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '5-11-1980' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
