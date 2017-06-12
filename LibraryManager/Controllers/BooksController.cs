using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManager.Models;
using LibraryManager.Migrations;
using LibraryManager.ViewModels;

/// <summary>
///  The Books Controller handles http requests and
///  invokes the corresponding action for :
///   /books/index
///   /books/details/id
///   /books/new
///   /books/edit/id
///   /books/save
///
///  The Books Controller maintains a reference to the 
///  database - ApplicationDbContext _context and makes
///  changes based on requests and post data.
/// </summary>

namespace LibraryManager.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Books

        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageBooks))
            {
                return View("Index");
            }

            return View("ReadOnlyIndex");
        }

        public ActionResult Details(int id)
        {
            var book = _context.Books.Include(b => b.Genre).SingleOrDefault(b => b.Id == id);

            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new BookFormViewModel
            {
                Genres = genres
            };

            return View("BookForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageBooks)]
        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);

            if (book == null)
            {
                return HttpNotFound();
            }

            var viewModel = new BookFormViewModel(book)
            {
               Genres = _context.Genres.ToList()
            };

            return View("BookForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel(book)
                {
                    Genres = _context.Genres.ToList()
                };
            }

            if (book.Id == 0)
            {
                book.DateAdded = DateTime.Now;
                book.NumberAvailable = book.NumberInStock;
                _context.Books.Add(book);
            }
            else
            {
                var bookInDb = _context.Books.Single(b => b.Id == book.Id);
                bookInDb.Title = book.Title;
                bookInDb.AuthorFirstName = book.AuthorFirstName;
                bookInDb.AuthorLastName = book.AuthorLastName;
                bookInDb.PublishDate = book.PublishDate;
                bookInDb.NumberInStock = book.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }
    }
}
