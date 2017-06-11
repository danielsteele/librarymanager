using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManager.Models;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }

        [Required]
        public byte BookId { get; set; }

        public BookDto Book { get; set; }

        [Required]
        public byte CustomerId { get; set; }

        public CustomerDto Customer { get; set; }
    }
}