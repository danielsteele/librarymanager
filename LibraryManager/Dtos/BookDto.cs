using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManager.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string AuthorLastName { get; set; }

        [Required]
        [StringLength(255)]
        public string AuthorFirstName { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime DateAdded { get; set; }

        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

    }
}