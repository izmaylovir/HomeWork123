public static class AppSettings
{
    public static string UserName { get; private set; }
    public static string Mode { get; private set; }
    public static int MaxConnections { get; private set; }
    static AppSettings()
    {
        UserName = "DefaultUser";
        Mode = "Development";
        MaxConnections = 10;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Имя пользователя: {AppSettings.UserName}");
        Console.WriteLine($"Режим работы: {AppSettings.Mode}");
        Console.WriteLine($"Максимальное количество подключений: {AppSettings.MaxConnections}");
    }
}