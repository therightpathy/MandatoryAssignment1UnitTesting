using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignment1UnitTesting
{
    public class Book
    {
        private string _title;
        private string _writer;
        private int _pageNo;
        private string _isbn13;

        public string Title
        {
            get => _title;
            set
            {
                CheckTitle(value);
                _title = value;
            }
        }

        public string Writer
        {
            get => _writer;
            set
            {
                CheckWriter(value);
                _writer = value;
            }
        }

        public int PageNo
        {
            get => _pageNo;
            set
            {
                CheckPageNo(value);
                _pageNo = value;
            }
        }

        public string Isbn13
        {
            get => _isbn13;
            set
            {
                CheckIsbn13(value);
                _isbn13 = value;
            }
        }

        public Book(string title, string writer, int pageNo, string isbn13)
        {
            CheckTitle(title);
            CheckWriter(writer);
            CheckPageNo(pageNo);
            CheckIsbn13(isbn13);
            Title = title;
            Writer = writer;
            PageNo = pageNo;
            Isbn13 = isbn13;
        }

        private static void CheckTitle(string title)
        {
            if (title.Length < 2)
            {
                throw new ArgumentException("Title is shorter than two characters");
            }
        }

        private static void CheckWriter(string writer)
        {
            if (string.IsNullOrWhiteSpace(writer))
            {
                throw new ArgumentException("Name is not written or empty");
            }
        }

        public static void CheckPageNo(int pageNo)
        {
            if (pageNo < 10 || pageNo > 1000)
            {
                throw new ArgumentException("The given page number must be between 10-1000");
            }
        }

        private static void CheckIsbn13(string isbn13)
        {
            if (isbn13.Length != 13)
            {
                throw new ArgumentException("The International Standard Book Number must be exactly 13 characters.");
            }
        }

    }
}