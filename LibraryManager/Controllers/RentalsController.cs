using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManager.Controllers
{
    public class RentalsController : Controller
    {
        // GET rentals
        public ActionResult Index()
        {
            return View();
        }

        // GET rentals/new
        public ActionResult New()
        {
            return View();
        }

        // GET rentals/return
        public ActionResult Return()
        {
            return View();
        }
    }


}