using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Decorator;
namespace Library.Flyweight
{
    class BookFactory
    {
        private static readonly Dictionary<string, IBook> booksCache = new();

        public static IBook GetBook(IBook book)
        {
            string key = $"{book.Name}-{book.Author}-{book.Category}";

            if (!booksCache.ContainsKey(key))
            {
                booksCache[key] = new Book(book.Name, book.Author, book.Category);
            }

            IBook baseBook = booksCache[key];

            if (book is BookDecorator decorator)
            {
                booksCache[key] = (IBook)Activator.CreateInstance(book.GetType(), baseBook);

                return (IBook)Activator.CreateInstance(book.GetType(), baseBook);
            }

            return baseBook;
        }


        public static List<IBook> GetAllBooks()
        {
            return booksCache.Values.ToList();
        }

    }
}
