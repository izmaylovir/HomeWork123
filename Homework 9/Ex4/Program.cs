enum Genre
{
    Action,
    Comedy,
    Drama,
    Horror,
    Romance,
    SciFi,
    Thriller
}

class Movie
{
    public string Title { get; set; }
    public int Id { get; set; }
    public Genre Genre { get; set; }
    public int Duration { get; set; }
    public int AgeRating { get; set; }
    public int Year { get; set; }
    public string Country { get; set; }
    public DateTime PremiereDate { get; set; }


    public Movie(string title, int id, Genre genre, int duration, int ageRating, int year, string country, DateTime premiereDate)
    {
        Title = title;
        Id = id;
        Genre = genre;
        Duration = duration;
        AgeRating = ageRating;
        Year = year;
        Country = country;
        PremiereDate = premiereDate;
    }
}

class Program
{
    static void Main()
    {
        Movie movie = new Movie("The Matrix", 1, Genre.SciFi, 136, 18, 1999, "USA", new DateTime(1999, 3, 31));

        Console.WriteLine("Movie Details:");
        Console.WriteLine($"Title: {movie.Title}");
        Console.WriteLine($"ID: {movie.Id}");
        Console.WriteLine($"Genre: {movie.Genre}");
        Console.WriteLine($"Duration: {movie.Duration} minutes");
        Console.WriteLine($"Age Rating: {movie.AgeRating}+");
        Console.WriteLine($"Year: {movie.Year}");
        Console.WriteLine($"Country: {movie.Country}");
        Console.WriteLine($"Premiere Date: {movie.PremiereDate}");
    }
}