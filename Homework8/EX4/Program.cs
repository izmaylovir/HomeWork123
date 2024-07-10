public class WeekendDates
{
    public static DateTime[] 
        GetDateTimes(DateTime startDate, DateTime endDate)
    {
        int maxWeekendCount = (int)((endDate - startDate).TotalDays / 7) * 2 + 2;

        DateTime[] weekendDates = new DateTime[maxWeekendCount];
        int index = 0;

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                weekendDates[index] = date;
                index++;
            }
        }
        DateTime[] actualWeekendDates = new DateTime[index];
        Array.Copy(weekendDates, actualWeekendDates, index);

        return actualWeekendDates;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, world");
        DateTime startDate = new DateTime(2022,7,1);
        DateTime endDate = new DateTime(2022, 7, 10);

        DateTime[] weekends = GetDateTimes(startDate, endDate);

        foreach (DateTime weekend in weekends)
        {
            Console.WriteLine(weekend.ToString("yyyy-MM-dd"));
        }
    }
}