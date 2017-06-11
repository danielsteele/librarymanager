using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManager;
using LibraryManager.Models;

namespace LibraryManager.Tests.Controllers
{
    [TestClass]
    public class CustomerModelTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            Customer model = new Customer
            {
                FirstName = "John",
                LastName = "Smith",
            };

            // Act
            string result = "John Smith";

            // Assert
            Assert.AreEqual(result, model.Name);
        }
    }
}

