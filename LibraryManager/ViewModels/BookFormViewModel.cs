using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManager.Models;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager.ViewModels
{
    public class BookFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        //public Book Book { get; set; }

        public int? Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Author Last Name")]
        [StringLength(255)]
        [Required]
        public string AuthorLastName { get; set; }

        [Display(Name = "Author First Name")]
        [Required]
        public string AuthorFirstName { get; set; }

        public string AuthorName => AuthorFirstName + " " + AuthorLastName;

        [Display(Name = "Date of Publication")]
        [Required]
        public DateTime? PublishDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required]
        public byte? NumberInStock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }


        public string HeadingTitle
        {
            get
            {
                return Id != 0 ? "Edit Book" : "New Book";
            }
        }

        public BookFormViewModel()
        {
            Id = 0;
        }

        public BookFormViewModel(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            AuthorFirstName = book.AuthorFirstName;
            AuthorLastName = book.AuthorLastName;

            
            PublishDate = book.PublishDate;


            NumberInStock = book.NumberInStock;
            GenreId = book.GenreId;
        }

        
    }
}