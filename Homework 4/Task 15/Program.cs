class Program
{
    static void Main()
    {
        int totalSeconds = 3670;
        int hours, minutes, seconds;

        ConvertTime(totalSeconds, out hours, out minutes, out seconds);

        Console.WriteLine("Total seconds: " + totalSeconds);
        Console.WriteLine("Converted time: " + hours + " hours, " + minutes + " minutes, " + seconds + " seconds");
    }
    static void ConvertTime(int totalSeconds, out int hours, out int minutes, out int seconds)
    {
        hours = totalSeconds / 3600;
        totalSeconds = totalSeconds % 3600;

        minutes = totalSeconds / 60;
        seconds = totalSeconds % 60;
    }
}