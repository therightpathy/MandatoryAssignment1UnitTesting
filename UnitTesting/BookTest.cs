using System;
using MandatoryAssignment1UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class BookTest
    {
        private Book _book;

        //Initializing test testing all methods
        [TestInitialize]
        public void BeforeTest()
        {
            _book = new Book("Immersion", "Peter Parker", 53, "9734657389123");
        }

        [TestMethod]
        public void TestTitle()
        {
            Assert.AreEqual("Immersion", _book.Title);
            _book.Title = "Reversion";
            Assert.AreEqual("Reversion", _book.Title);
            try
            {
                _book.Title = "i";
            }
            catch (Exception e)
            {
                Assert.AreEqual("Title is shorter than two characters", e.Message);
            }
        }

        [TestMethod]
        public void TestWriter()
        {
            Assert.AreEqual("Peter Parker", _book.Writer);
            _book.Writer = "Alexander Henderson";
            Assert.AreEqual("Alexander Henderson", _book.Writer);
            try
            {
                _book.Writer = null;
                Assert.Fail();
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Name is not written or empty", ex.Message);
            }
        }

        [TestMethod]
        public void TestPageNo()
        {
            Assert.AreEqual(53, _book.PageNo);
            _book.PageNo = 88;
            Assert.AreEqual(88, _book.PageNo);

            try
            {
                _book.PageNo = 9;
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The given page number must be between 10-1000", e.Message);
            }

        }

        [TestMethod]
        public void TestIsbn13()
        {
            Assert.AreEqual("9734657389123", _book.Isbn13);
            _book.Isbn13 = "6747869356421";
            Assert.AreEqual("6747869356421", _book.Isbn13);
            try
            {
                _book.Isbn13 = "123456789012";
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual("The International Standard Book Number must be exactly 13 characters.", e.Message);
            }
        }
    }
}