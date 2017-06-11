namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWebApiDtos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Books", "AuthorLastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Books", "AuthorFirstName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "AuthorFirstName", c => c.String());
            AlterColumn("dbo.Books", "AuthorLastName", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
        }
    }
}
