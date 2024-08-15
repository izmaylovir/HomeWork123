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
    }

    public void RemoveBook(string title)
    {
        Book bookToRemove = books.Find(b => b.Title == title);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
        }
    }

    public Book FindBook(string title)
    {
        return books.Find(b => b.Title == title);
    }

    public void PrintAllBooks()
    {
        foreach (var book in books)
        {
            book.PrintInfo();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book { Title = "Book1", Author = "Author1", Pages = 100 };
        Book book2 = new Book { Title = "Book2", Author = "Author2", Pages = 150 };

        library.AddBook(book1);
        library.AddBook(book2);

        Console.WriteLine("Список книг в библиотеке:");
        library.PrintAllBooks();

        Console.WriteLine("\nУдаление книги с названием 'Book1'");
        library.RemoveBook("Book1");

        Console.WriteLine("\nСписок книг в библиотеке после удаления:");
        library.PrintAllBooks();

        Console.WriteLine("\nПоиск книги с названием 'Book2':");
        Book foundBook = library.FindBook("Book2");
        if (foundBook != null)
        {
            foundBook.PrintInfo();
        }
        else
        {
            Console.WriteLine("Книга не найдена");
        }
    }
}