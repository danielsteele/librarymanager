namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Science Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action and Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Non-Fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
