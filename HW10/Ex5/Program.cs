public enum Genre
{
    Action,
    Comedy,
    Drama,
    Horror,
    SciFi,
    Romance,
    Thriller,
    Documentary
}

public class Movie
{

    public string Title { get; set; }
    public int Id { get; set; }
    public Genre Genre { get; set; }
    public int DurationInMinutes { get; set; }
    public string AgeRating { get; set; }
    public int YearOfProduction { get; set; }
    public string CountryOfProduction { get; set; }
    public DateTime PremiereDate { get; set; }

    public Movie()
    {
        Title = "Unknown";
        Id = 0;
        Genre = Genre.Action; 
        DurationInMinutes = 0;
        AgeRating = "N/A";
        YearOfProduction = 0;
        CountryOfProduction = "Unknown";
        PremiereDate = DateTime.MinValue;
    }
    public Movie(string title, int id, Genre genre, int durationInMinutes,
                 string ageRating, int yearOfProduction,
                 string countryOfProduction, DateTime premiereDate)
    {
        Title = title;
        Id = id;
        Genre = genre;
        DurationInMinutes = durationInMinutes;
        AgeRating = ageRating;
        YearOfProduction = yearOfProduction;
        CountryOfProduction = countryOfProduction;
        PremiereDate = premiereDate;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie("Inception", 1, Genre.SciFi, 148, "PG-13", 2010, "USA", new DateTime(2010, 7, 16)),
            new Movie("The Godfather", 2, Genre.Drama, 175, "R", 1972, "USA", new DateTime(1972, 3, 24)),
            new Movie("The Dark Knight", 3, Genre.Action, 152, "PG-13", 2008, "USA", new DateTime(2008, 7, 18)),
            new Movie("Parasite", 4, Genre.Thriller, 132, "R", 2019, "South Korea", new DateTime(2019, 5, 30)),
            new Movie("Toy Story", 5, Genre.Comedy, 81, "G", 1995, "USA", new DateTime(1995, 11, 22))
        };
        Console.WriteLine("Movies List:");
        foreach (var movie in movies)
        {
            Console.WriteLine($"Title: {movie.Title}");
            Console.WriteLine($"ID: {movie.Id}");
            Console.WriteLine($"Genre: {movie.Genre}");
            Console.WriteLine($"Duration: {movie.DurationInMinutes} minutes");
            Console.WriteLine($"Age Rating: {movie.AgeRating}");
            Console.WriteLine($"Year of Production: {movie.YearOfProduction}");
            Console.WriteLine($"Country of Production: {movie.CountryOfProduction}");
            Console.WriteLine($"Premiere Date: {movie.PremiereDate.ToShortDateString()}");
            Console.WriteLine(new string('-', 30)); 
        }
    }
}