using Library.Proxy;

namespace Library.Flyweight
{
    public class Book : IBook

    {
        public static int IdCode = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public BookCategory Category { get; set; }
        public bool IsItBorrowed { get; set; }
        public DateTime BorrowingDate { get; set; }
        public Book(string name, string Auther, BookCategory Category)
        {
            Id = ++IdCode;
            Name = name;
            Author = Auther;
            IsItBorrowed = false;
            this.Category = Category;

        }
        public Book()
        {
            Id = ++IdCode;
        }
        public override string ToString()
        {
            return $"Name is:{Name}\nAuthor is:{Author}\nId is:{Id}\nIsItBorrowed is:{IsItBorrowed}\nBorrowingDate is:{BorrowingDate}\n";
        }

        public bool Borrow(User user)
        {
            if (IsItBorrowed)
                return false;
            IsItBorrowed = true;
            BorrowingDate = DateTime.Now;
            return true;
        }


        public bool Return()
        {
            if (!IsItBorrowed)
                return false;
            IsItBorrowed = false;
            return true;
        }


    }
}
