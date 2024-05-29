using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK
{
    internal class Library
    {
        public void AddBook(string title, string author, int year)
        {
          List<Book> books = new List<Book>();
          Book book = new Book();
            book.Title = title;
            book.Author = author;
            book.Year = year;
            books.Add(book);




        }

    }
}
