﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManager.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rentals/New
        public ActionResult New()
        {
            return View();
        }

        // GET: Rentals/Return
        public ActionResult Return()
        {
            return View();
        }
    }


}