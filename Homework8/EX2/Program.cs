class DateHelper
{
    public static DateTime GetStartOfWeek(DateTime date)
    {
        DayOfWeek dayOfWeek = date.DayOfWeek;
        int daysToSubtract = (int)dayOfWeek - 1; 
        if (daysToSubtract < 0) daysToSubtract += 7; 
        return date.AddDays(-daysToSubtract);
    }
    static void Main()
    {
        DateTime inputDate = new DateTime(2024, 10, 15); 
        DateTime startOfWeek = GetStartOfWeek(inputDate);
        Console.WriteLine("Дата начала недели для {0} : {1}", inputDate.ToString("dd/MM/yyyy"), startOfWeek.ToString("dd/MM/yyyy"));
    }
}
