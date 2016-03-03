using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class BooksFactory
    {
        public static IEnumerable<book> CreateBooks()
        {
            List<book> books=new List<book>();
            books.Add(new book("Central park","Guillaume Musso"));
            books.Add(new book("The one plus one", "Jojo Moyes"));
            books.Add(new book("Pride and Prejudice", "Jane Austen"));
            books.Add(new book("Harry Potter and the Chamber of Secrets", "J.K. Rowling"));
            return books;
        }
    }
}