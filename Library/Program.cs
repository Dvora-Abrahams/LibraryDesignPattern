using Library;
using Library.Decorator;
using Library.Bridge;
using Library.Composite;
using Library.Facade;
using Library.Flyweight;
using Library.Proxy;
using Library.AdapterFolder;

// Create users
User regularUser = new User("moshe", false);
User premiumUser = new User("esti", true);
//BooksInCategory booksCategory = new BooksInCategory();


BooksInCategory youngAdult = new BooksInCategory(BookCategory.YoungAdult, new List<BooksInCategory>() , new TextColorDisplay());
BooksInCategory holocaust = new BooksInCategory(BookCategory.Holocaust, new List<BooksInCategory>() , new TextColorDisplay());
BooksInCategory children = new BooksInCategory(BookCategory.ChildrensBooks, new List<BooksInCategory>(), new BackgroundColorDisplay());
BooksInCategory adult = new BooksInCategory(BookCategory.Adult, new List<BooksInCategory>() { youngAdult, holocaust,children },new BackgroundColorDisplay());


// Create books
IBook thrillerBook = BookFactory.GetBook(new Book("the book", "Avigail", BookCategory.YoungAdult));
IBook rareBook = BookFactory.GetBook(new RareBookDecorator(new Book("Codex Leicester", "Leonardo da Vinci", BookCategory.YoungAdult)));
IBook adultBook = BookFactory.GetBook(new Book("The glass", "Shoshana", BookCategory.Adult));
IBook childrenBook = BookFactory.GetBook(new Book("chocolate factory", "David", BookCategory.ChildrensBooks));
IBook libraryOnly =BookFactory.GetBook(new LibraryOnlyDecorator(new Book("old book", "dont know", BookCategory.Adult)));

// Create library system (Facade)
LibraryFacade library = new LibraryFacade(adult);


library.AddBook(thrillerBook);
library.AddBook(rareBook);
library.AddBook(adultBook);
library.AddBook(childrenBook);
library.AddBook(libraryOnly);

library.PrintAllBooks();

Console.WriteLine();
Console.WriteLine("************************************");
Console.WriteLine();
// Try borrowing books
Console.WriteLine($"Regular user {regularUser.Name} borrowing thriller book: " + library.BorrowBook("the book", regularUser));
Console.WriteLine();
Console.WriteLine($"Regular user {regularUser.Name} borrowing rare book: " + library.BorrowBook("Codex Leicester",regularUser));
Console.WriteLine();
Console.WriteLine($"Premium user {premiumUser.Name} borrowing rare book: " + library.BorrowBook("Codex Leicester", premiumUser));
Console.WriteLine();
Console.WriteLine($"Premium user {premiumUser.Name} borrowing thriller book: " + library.BorrowBook("the book", premiumUser));
Console.WriteLine();
Console.WriteLine($"Premium user {premiumUser.Name} borrowing thriller book: " + library.BorrowBook("The glass", premiumUser));
Console.WriteLine();
Console.WriteLine($"Premium user {premiumUser.Name} borrowing thriller book: " + library.BorrowBook("chocolate factory", premiumUser));
Console.WriteLine();
Console.WriteLine($"Regular user {regularUser.Name} borrowing library only book: " + library.BorrowBook("Old book", regularUser));
Console.WriteLine();
Console.WriteLine("************************************");
Console.WriteLine();
Console.WriteLine("Regular user returned thriller book: " + library.ReturnBook("the book"));
Console.WriteLine();
Console.WriteLine("Regular user returned rare book: " + library.ReturnBook("Codex Leicester"));
Console.WriteLine();
Console.WriteLine("Premium user returned thriller book: " + library.ReturnBook("the book"));
Console.WriteLine();
Console.WriteLine("Premium user returned thriller book: " + library.ReturnBook("The glass"));
Console.WriteLine();
Console.WriteLine("Premium user returned thriller book: " + library.ReturnBook("chocolate factory"));



// Display book colors
TextColorDisplay colorDisplay = new TextColorDisplay();
colorDisplay.Color(new Green());
colorDisplay.display();
Console.WriteLine("This is a green-colored text.");

Console.ResetColor();

