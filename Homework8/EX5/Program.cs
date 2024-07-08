class DateHelper
{
    public static int CountWeekendDaysInRange(DateTime startDate, DateTime endDate)
    {
        int count = 0;

        for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        DateTime startDate = new DateTime(2022, 10, 1); // Пример начальной даты
        DateTime endDate = new DateTime(2022, 10, 31); // Пример конечной даты
        int weekendDaysCount = CountWeekendDaysInRange(startDate, endDate);

        Console.WriteLine($"Количество выходных дней в заданном промежутке: {weekendDaysCount}");
    }
}