public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public Book()
    {
        Title = "Неизвестно";
        Author = "Неизвестно";
        Year = 0;
    }
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        Year = 0;
    }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        Book book2 = new Book("1984", "Джордж Оруэлл");
        Book book3 = new Book("Мастер и Маргарита", "Михаил Булгаков", 1967);

        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
    }
}