using Library.Flyweight;
using Library.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Decorator
{
    class LibraryOnlyDecorator : BookDecorator
    {
        public LibraryOnlyDecorator(IBook book) : base(book)
        {
        }
        public override bool Borrow(User user)
        {
            Console.WriteLine("The book is intended for reading in the library only!");
            return false;
        }

        public override bool Return()
        {
            Console.WriteLine("The book is intended for reading in the library only!");
            return false;
        }
    }
}

