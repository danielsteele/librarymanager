using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManager;
using LibraryManager.Controllers;

namespace LibraryManager.Tests.Controllers
{
    [TestClass]
    public class RentalsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            RentalsController controller = new RentalsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void New()
        {
            // Arrange
            RentalsController controller = new RentalsController();

            // Act
            ViewResult result = controller.New() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Return()
        {
            // Arrange
            RentalsController controller = new RentalsController();

            // Act
            ViewResult result = controller.Return() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
