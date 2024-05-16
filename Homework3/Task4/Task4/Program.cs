class Song
{
    public string Artist { get; set; }
    public string Title { get; set; }
    public int DurationInSeconds { get; set; }

    public Song(string artist, string title, int durationInSeconds)
    {
        Artist = artist;
        Title = title;
        DurationInSeconds = durationInSeconds;
    }

    public string GetFormattedDuration()
    {
        int minutes = DurationInSeconds / 60;
        int seconds = DurationInSeconds % 60;
        return $"{minutes}:{seconds:D2}";
    }
}

class Program
{
    static void Main()
    {
        Song song1 = new Song("Imagine Dragons", "Believer", 204); 
        Song song2 = new Song("Ed Sheeran", "Shape of You", 232); 

        Song shorterSong = song1.DurationInSeconds < song2.DurationInSeconds ? song1 : song2;

        Console.WriteLine($"{shorterSong.Artist} - {shorterSong.Title} {shorterSong.GetFormattedDuration()}");
    }
}