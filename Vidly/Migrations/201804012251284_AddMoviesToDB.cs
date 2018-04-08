namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Romance')");

            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, NumberInStock, Name, ReleaseDate, DateAdded, GenreId) VALUES (2, 1, 'Die Hard', 1998-07-15, 2000-02-25, 1)");
            Sql("INSERT INTO Movies (Id, NumberInStock, Name, ReleaseDate, DateAdded, GenreId) VALUES (3, 1, 'The Terminator', 1984-10-26, 2002-06-11, 1)");
            Sql("INSERT INTO Movies (Id, NumberInStock, Name, ReleaseDate, DateAdded, GenreId) VALUES (4, 1, 'Toy Story', 1995-11-22, 2003-04-18, 3)");
            Sql("INSERT INTO Movies (Id, NumberInStock, Name, ReleaseDate, DateAdded, GenreId) VALUES (5, 1, 'Titanic', 1997-12-19, 2000-05-28, 5)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
