namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBooks : DbMigration
    {
        public override void Up()
        {
            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Dune', 'Herbert', 'Frank', '1-1-1965', '2-6-2010', 5, 1)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Hyperion', 'Simmons', 'Dan', '1-1-1990', '7-6-2010', 5, 1)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Neuromancer', 'Gibson', 'William', '1-1-1984', '10-6-2011', 3, 1)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Treasure Island', 'Stevenson', 'Robert Louis', '1-1-1883', '8-8-2013', 3, 2)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('The Three Musketeers', 'Dumas', 'Alexandre', '1-1-1844', '2-6-2010', 5, 2)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('King Solomon''s Mines', 'Haggard', 'H. Rider', '1-1-1885', '11-11-2012', 3, 2)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Pride and Predjudice', 'Austen', 'Jane', '1-1-1813', '7-1-2015', 5, 3)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('The Notebook', 'Sparks', 'Nicholas', '1-1-2004', '9-10-2016', 5, 3)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Emma', 'Austen', 'Jane', '1-1-1815', '3-12-2014', 3, 3)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Murder on the Orient Express', 'Christie', 'Agatha', '1-1-1934', '2-6-2010', 3, 4)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('And Then There Were None', 'Christie', 'Agatha', '1-1-1936', '4-11-2011', 3, 4)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Gone Girl', 'Flynn', 'Gillian', '1-1-2012', '5-5-2010', 5, 4)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('The Double Helix', 'Watson', 'James', '1-1-1968', '3-7-2011', 3, 5)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('The Moral Landscape', 'Harris', 'Sam', '1-1-2015', '5-8-2016', 5, 5)");

            Sql(
                "INSERT INTO Books (Title, AuthorLastName, AuthorFirstName, PublishDate, DateAdded, NumberInStock, GenreId)" +
                "VALUES ('Guns, Germs and Steel', 'Diamond', 'Jared', '1-1-1997', '2-6-2010', 3, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
