class DateHelper
{
    public static DateTime[] GetDateRange(DateTime startDate, DateTime endDate)
    {
        int daysCount = (int)(endDate - startDate).TotalDays + 1;
        DateTime[] dateRange = new DateTime[daysCount];

        for (int i = 0; i < daysCount; i++)
        {
            dateRange[i] = startDate.AddDays(i);
        }

        return dateRange;
    }

    static void Main()
    {
        DateTime startDate = new DateTime(2022, 10, 1); 
        DateTime endDate = new DateTime(2022, 10, 10); 
        DateTime[] range = GetDateRange(startDate, endDate);

        Console.WriteLine("Даты в заданном промежутке:");
        foreach (DateTime date in range)
        {
            Console.WriteLine(date.ToShortDateString());
        }
    }
}