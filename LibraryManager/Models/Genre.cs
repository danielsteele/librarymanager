using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    /*
        Model the genre of a book.
        One to many relationship to the Book table.
    */

    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}