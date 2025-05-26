using Library.Flyweight;
using Library.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Decorator
{
    class RareBookDecorator : BookDecorator
    {

        public RareBookDecorator(IBook book) : base(book)
        {
        }

        public override bool Borrow(User user)
        {

            if (!user.IsPremium)
            {
                Console.WriteLine($"❌ {user.Name}, You are not a premium user! A rare book can only be borrowed by premium users..");
                return false;
            }

            return book.Borrow(user);
        }

        public override bool Return()
        {
            return book.Return();
        }
    }
}
