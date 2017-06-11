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
    public class BookModelTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            Book model = new Book {
                Title = "test title",
                AuthorFirstName = "John",
                AuthorLastName = "Smith",
                PublishDate = new DateTime(2000, 1, 1),
                NumberInStock = 1,
                GenreId = 1
            };

            // Act
            string result = "John Smith";

            // Assert
            Assert.AreEqual(result, model.AuthorName);
        }
    }
}
