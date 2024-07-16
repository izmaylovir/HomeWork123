class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
}

class BookService
{
    public List<string> GetBookTitles(List<Book> books)
    {
        return books.Select(b => b.Title).ToList();
    }

    public Book GetFirstBookOlderThanYear(List<Book> books, int year)
    {
        return books.FirstOrDefault(b => b.Year > year);
    }

    public List<Book> SortByTitle(List<Book> books)
    {
        return books.OrderBy(b => b.Title).ToList();
    }

    public List<Book> SortByAuthor(List<Book> books)
    {
        return books.OrderBy(b => b.Author).ToList();
    }

    public void PrintBookInfo(List<Book> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, Genre: {book.Genre}");
        }
    }

    public List<Book> FindBooksByTitle(List<Book> books, string searchQuery)
    {
        return books.Where(b => b.Title.Contains(searchQuery)).ToList();
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>
        {
            new Book {Title = "Book1", Author = "Author1", Year = 2000, Genre = "Fiction"},
            new Book {Title = "Book2", Author = "Author2", Year = 1990, Genre = "Non-fiction"},
            new Book {Title = "Book3", Author = "Author3", Year = 2010, Genre = "Fantasy"}
        };

        BookService service = new BookService();

        List<string> titles = service.GetBookTitles(books);
        foreach (var title in titles)
        {
            Console.WriteLine(title);
        }

        Console.WriteLine();

        List<Book> sortedByAuthor = service.SortByAuthor(books);
        service.PrintBookInfo(sortedByAuthor);

        Console.WriteLine();

        List<Book> foundBooks = service.FindBooksByTitle(books, "Book1");
        service.PrintBookInfo(foundBooks);
    }
}