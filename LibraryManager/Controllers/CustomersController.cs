using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using LibraryManager.Models;
using LibraryManager.ViewModels;

/// <summary>
///  The Customers Controller handles http requests and
///  invokes the corresponding action for :
///   [GET] /customers/index
///   [GET] /customers/details/id
///   [GET] /customerss/new
///   [GET] /customers/edit/id
///   [POST] /customers/save
///
///  The Customers Controller maintains a reference to the 
///  database - ApplicationDbContext _context and makes
///  changes based on requests and post data.
/// </summary>

namespace LibraryManager.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET customers/index
        public ActionResult Index()
        {
            // now an ajax request is sent from the client to the api that fetches
            // the list of customers
            return View();
        }

        // GET customers/details/1
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        // GET customers/edit/1
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                HeadingTitle = "Edit Customer",
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        // GET customers/new
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                HeadingTitle = "New Customer",
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        // POST customers/save
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            // validation
            if (!ModelState.IsValid)
            {
                // customer object is placed in the request body

                // if the model state is not valid, return the same view
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
                // validation error messages shown in CustomerForm
            }

            //test if there is an existing customer to update, or a new one to create
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                //TryUpdateModel(customerInDb, "", new string[] { "Name", "Email"});
                customerInDb.FirstName = customer.FirstName;
                customerInDb.LastName = customer.LastName;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
    }
}
