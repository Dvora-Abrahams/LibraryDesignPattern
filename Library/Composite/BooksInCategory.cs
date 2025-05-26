using Library.Bridge;
using Library.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Library.AdapterFolder;
using Library.Flyweight;

namespace Library.Composite
{
    class BooksInCategory
    {
        BookCategory Category { get; set; }
        List<BooksInCategory> SubCategories = new List<BooksInCategory>();
        List<IBook> books = new List<IBook>();
        ColorDisplay colorDisplay;
        Adapter adapter;

        public BooksInCategory(BookCategory category, List<BooksInCategory> subCategories, ColorDisplay colorDisplay)
        {
            Category = category;
            SubCategories = subCategories;
            this.colorDisplay = colorDisplay;
            adapter = new Adapter(colorDisplay);
        }


        public bool Add(IBook book)
        {
            if (Category == book.Category)
            {
                books.Add(book);
                return true;
            }
            if (SubCategories == null)
            {
                return false;
            }
            foreach (var cat in SubCategories)
            {
                if (book.Category.HasFlag(cat.Category))
                    return cat.Add(book);
            }
            return false;
        }
        public void Print()
        {

            foreach (var b in books)
            {
                adapter.Print(GetOriginalBook(b).Category);
                Console.WriteLine(GetOriginalBook(b).ToString());
                adapter.Reaset();
            }
            foreach (var cat in SubCategories)
            {
                cat.Print();
            }
            //adapter.Reaset();
        }
        public IBook GetOriginalBook(IBook book)
        {
            while (book is BookDecorator decorator)
            {
                book = decorator.book;
            }
            return book;
        }

        public IBook FindByName(string name)
        {

            IBook foundBook = books.FirstOrDefault(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (foundBook != null)
            {
                return foundBook;
            }


            foreach (var subCategory in SubCategories)
            {
                foundBook = subCategory.FindByName(name);
                if (foundBook != null)
                {
                    return foundBook;
                }
            }


            return foundBook;
        }






    }
}
