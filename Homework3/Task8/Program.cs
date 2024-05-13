struct Date
{
    public int Day;
    public int Month;
    public int Year;

    public string GetFormattedDate()
    {
        return $"{Day:D2}.{Month:D2}.{Year:D4}";
    }
}

class Program
{
    static void Main()
    {
        Date date = new Date();
        date.Day = 09;
        date.Month = 9;
        date.Year = 2005;

        Console.WriteLine(date.GetFormattedDate());
    }
}