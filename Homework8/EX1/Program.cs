class DateGenerator
{
    private static readonly Random random = new Random();

    public static DateTime GenerateRandomDate(int year)
    {
        int day = random.Next(1, 29); 
        int month = random.Next(1, 13); 
        return new DateTime(year, month, day);
    }

    static void Main()
    {
        int year = 2022; 
        DateTime randomDate = GenerateRandomDate(year);
        Console.WriteLine("Сгенерированная дата: " + randomDate.ToString("dd/MM/yyyy"));
    }
}