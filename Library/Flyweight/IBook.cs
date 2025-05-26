using Library.Proxy;

namespace Library.Flyweight
{
    public interface IBook
    {
        string Author { get; set; }
        string Name { get; set; }
        //DateTime BorrowingDate { get; set; }
        BookCategory Category { get; set; }
        int Id { get; set; }
        //bool IsItBorrowed { get; set; }


        bool Borrow(User user);

        public bool Return();
        string ToString();
    }

}