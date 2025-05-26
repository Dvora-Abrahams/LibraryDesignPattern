using Library.Flyweight;
using Library.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Decorator
{
    abstract class BookDecorator : IBook
    {

        public IBook book;

        protected BookDecorator(IBook book)
        {
            this.book = book;
        }

        public string Name { get => book.Name; set => book.Name = value; }
        public BookCategory Category { get => book.Category; set => book.Category = value; }
        public int Id { get => book.Id; set => book.Id = value; }
        public string Author { get => book.Author; set => book.Author = value; }

        public virtual bool Borrow(User user)
        {
            return book.Borrow(user);
        }

        public virtual bool Return()
        {
            return book.Return();
        }
    }
}
