class DateHelper
{
    public static DateTime GetEndOfWeek(DateTime date)
    {
        DayOfWeek dayOfWeek = date.DayOfWeek;
        int daysToAdd = 6 - (int)dayOfWeek; 
        return date.AddDays(daysToAdd);
    }

    static void Main()
    {
        DateTime inputDate = new DateTime(2024, 9, 10); 
        DateTime endOfWeek = GetEndOfWeek(inputDate);
        Console.WriteLine("Дата окончания недели для {0} : {1}", inputDate.ToString("dd/MM/yyyy"), endOfWeek.ToString("dd/MM/yyyy"));
    }
}