using System;
using System.Collections.Generic;
using System.Linq;

public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }

    public Movie(string title, string director, int year)
    {
        Title = title;
        Director = director;
        Year = year;
    }
}

public class MovieService
{
    private List<Movie> movies;

    public MovieService()
    {
        movies = new List<Movie>();
    }
    public void AddMovie(Movie movie)
    {
        if (movie == null)
            throw new ArgumentNullException(nameof(movie), "Фильм не может быть null.");

        movies.Add(movie);
    }
    public bool RemoveMovie(string title)
    {
        var movieToRemove = movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (movieToRemove != null)
        {
            movies.Remove(movieToRemove);
            return true;
        }
        return false;
    }
    public List<Movie> GetAllMovies()
    {
        return new List<Movie>(movies);
    }
  public Movie FindMovieByTitle(string title)
    {
        return movies.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
    public List<Movie> GetMoviesByDirector(string director)
    {
        return movies.Where(m => m.Director.Equals(director, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    public List<Movie> GetMoviesAfterYear(int year)
    {
        return movies.Where(m => m.Year > year).ToList();
    }
}
class Program
{
    static void Main(string[] args)
    {
        MovieService movieService = new MovieService();
        movieService.AddMovie(new Movie("Inception", "Christopher Nolan", 2010));
        movieService.AddMovie(new Movie("Interstellar", "Christopher Nolan", 2014));
        movieService.AddMovie(new Movie("The Matrix", "Lana Wachowski, Lilly Wachowski", 1999));

        var allMovies = movieService.GetAllMovies();
        Console.WriteLine("Все фильмы:");
        foreach (var movie in allMovies)
        {
            Console.WriteLine($"{movie.Title} ({movie.Year}) - Режиссер: {movie.Director}");
        }
        var foundMovie = movieService.FindMovieByTitle("Inception");
        Console.WriteLine($"Найденный фильм: {foundMovie?.Title ?? "Не найден"}");
        var nolanMovies = movieService.GetMoviesByDirector("Christopher Nolan");
        Console.WriteLine("Фильмы Кристофера Нолана:");
        foreach (var movie in nolanMovies)
        {
            Console.WriteLine(movie.Title);
        }

        bool isRemoved = movieService.RemoveMovie("The Matrix");
        Console.WriteLine($"Фильм 'The Matrix' удален: {isRemoved}");
        var recentMovies = movieService.GetMoviesAfterYear(2010);
        Console.WriteLine("Фильмы после 2010 года:");
        foreach (var movie in recentMovies)
        {
            Console.WriteLine(movie.Title);
        }
    }
}
