public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
    }
}

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }

    public void RemoveBook(string title)
    {
        Book bookToRemove = books.Find(b => b.Title == title);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book '{title}' removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
    }

    public void FindBook(string title)
    {
        Book foundBook = books.Find(b => b.Title == title);
        if (foundBook != null)
        {
            Console.WriteLine($"Book '{title}' found in the library:");
            foundBook.PrintInfo();
        }
        else
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        Book book1 = new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Pages = 180 };
        Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Pages = 281 };

        library.AddBook(book1);
        library.AddBook(book2);

        library.FindBook("To Kill a Mockingbird");

        library.RemoveBook("The Great Gatsby");
        library.FindBook("The Great Gatsby");
    }
}