class DateHelper
{
    public static DateTime GetEndOfWeek(DateTime date)
    {
        DayOfWeek dayOfWeek = date.DayOfWeek;
        int daysToAdd =  7 - (int)dayOfWeek;
        if (dayOfWeek == DayOfWeek.Sunday)
        { 
            daysToAdd = 0; 
        }
        return date.AddDays(daysToAdd);
    }


    static void Main()
    {
        DateTime inputDate = new DateTime(2022,8,3); 
        DateTime endOfWeek = GetEndOfWeek(inputDate);
        Console.WriteLine("Дата окончания недели для {0} : {1}", inputDate.ToString("dd/MM/yyyy"), endOfWeek.ToString("dd/MM/yyyy"));
    }
}