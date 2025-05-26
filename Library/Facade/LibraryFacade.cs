using Library.Composite;
using Library.Flyweight;
using Library.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Facade
{
    class LibraryFacade
    {
        private BooksInCategory rootCategory;

        public LibraryFacade(BooksInCategory rootCategory)
        {
            this.rootCategory = rootCategory;
        }
        public bool AddBook(IBook book)
        {
            return rootCategory.Add(BookFactory.GetBook(book));
        }

        public IBook FindBook(string title)
        {
            return rootCategory.FindByName(title);


        }



        public bool BorrowBook(string title, User user)
        {
            IBook book = FindBook(title);
            if (book == null)
            {
                Console.WriteLine(" The book is not found.");
                return false;
            }

            if (!book.Borrow(user))
            {
                Console.WriteLine(" The book cannot be borrowed.");
                return false;
            }

            Console.WriteLine($" The book: '{book.Name}' borrowed successfully!");
            return true;
        }


        public bool ReturnBook(string title)
        {
            IBook book = FindBook(title);
            if (book == null)
            {
                Console.WriteLine(" The book is not found..");
                return false;
            }

            if (!book.Return())
            {
                Console.WriteLine(" The book was not borrowed..");
                return false;
            }

            Console.WriteLine($" the book: '{book.Name}' returned successfully!");
            return true;
        }

        public void PrintAllBooks()
        {
            rootCategory.Print();

        }
    }
}

