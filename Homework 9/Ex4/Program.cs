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

    public Movie()
    {
        
    }

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