using AutoMapper;
using LibraryManager.Dtos;
using LibraryManager.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics;
using System.Data.Entity.Validation;

namespace LibraryManager.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetRentals(string query = null)
        {
            var rentalsQuery = _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Book)
                .Where(r => r.DateReturned == null);

            if (!String.IsNullOrWhiteSpace(query))
            {
                rentalsQuery = rentalsQuery.Where(r => r.Customer.Name.Contains(query));
            }

            var rentalDtos = rentalsQuery
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalDtos);

            //return _context.Books
            //    .Include(b => b.Genre)
            //    .ToList()
            //    .Select(Mapper.Map<Book, BookDto>);
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.BookIds.Count == 0)
            {
                return BadRequest("No Book Ids have been given.");
            }

            var customer = _context.Customers.SingleOrDefault(
                c => c.Id == newRental.CustomerId);

            if (customer == null)
            {
                return BadRequest("CustomerId is not valid.");
            }

            var books = _context.Books.Where(
                b => newRental.BookIds.Contains(b.Id)).ToList();

            if (books.Count != newRental.BookIds.Count)
            {
                return BadRequest("One or more bookIds are invalid.");
            }

            foreach (var book in books)
            {
                if (book.NumberAvailable == 0)
                {
                    return BadRequest("Book is not available.");
                }

                book.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Book = book,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult UpdateNewRentals(NewRentalDto rentalDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var booksInDb = _context.Books.Where(
                b => rentalDto.BookIds.Contains(b.Id)).ToList();

            foreach (var book in booksInDb)
            {
                var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Customer.Id == rentalDto.CustomerId && r.Book.Id == book.Id);

                if (rentalInDb == null)
                {
                    return BadRequest();
                }

                var customer = _context.Customers.SingleOrDefault(c => c.Id == rentalDto.CustomerId);

                rentalInDb.Customer = customer;
                rentalInDb.DateReturned = DateTime.Now;
                book.NumberAvailable++;
            }


            try
            {
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            return Ok();
        }
    }
}