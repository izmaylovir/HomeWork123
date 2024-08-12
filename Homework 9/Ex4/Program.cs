public enum Genre
{
    Action,
    SciFi,
    Drama,
    Comedy,
    Horror
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

    public Movie() { }

    public Movie(string title, int id, Genre genre, int duration, string ageRating, int year, string country, DateTime premiereDate)
    {
        Title = title;
        Id = id;
        Genre = genre;
        DurationInMinutes = duration;
        AgeRating = ageRating;
        YearOfProduction = year;
        CountryOfProduction = country;
        PremiereDate = premiereDate;
    }
}

public class MovieService
{
    private List<Movie> movies;

    public MovieService(List<Movie> movies)
    {
        this.movies = movies;
    }

    public void PrintAllMovieTitles()
    {
        foreach (var movie in movies)
        {
            Console.WriteLine(movie.Title);
        }
    }

    public void FindOldestMovie()
    {
        var oldestMovie = movies.Find(m => m.YearOfProduction == movies.Min(x => x.YearOfProduction));
        Console.WriteLine("Самый старый фильм: " + oldestMovie.Title);
    }

    public void FindLongestMovie()
    {
        var longestMovie = movies.Find(m => m.DurationInMinutes == movies.Max(x => x.DurationInMinutes));
        Console.WriteLine("Самый длительный фильм: " + longestMovie.Title);
    }

    public void FilterMoviesByRating(string rating)
    {
        var filteredMovies = movies.FindAll(m => m.AgeRating == rating);
        Console.WriteLine("Фильмы с рейтингом " + rating + ":");
        foreach (var movie in filteredMovies)
        {
            Console.WriteLine(movie.Title);
        }
    }

    public void SortMoviesByReleaseDate()
    {
        movies.Sort((x, y) => x.YearOfProduction.CompareTo(y.YearOfProduction));
    }

    public void PrintAllMovies()
    {
        foreach (var movie in movies)
        {
            Console.WriteLine($"{movie.Title} ({movie.YearOfProduction}) - {movie.Genre}, {movie.DurationInMinutes} мин.");
        }
    }
}

class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>();
        movies.Add(new Movie("Inception", 1, Genre.SciFi, 148, "PG-13", 2010, "USA", new DateTime(2010, 7, 16)));
        movies.Add(new Movie("The Matrix", 2, Genre.Action, 136, "R", 1999, "USA", new DateTime(1999, 3, 31)));
        MovieService movieService = new MovieService(movies);
        movieService.PrintAllMovieTitles();
        movieService.FindOldestMovie();
        movieService.FindLongestMovie();
        movieService.FilterMoviesByRating("PG-13");
        movieService.SortMoviesByReleaseDate();
        movieService.PrintAllMovies();
    }
}