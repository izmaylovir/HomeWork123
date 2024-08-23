public static class Logger
{
    public static void LogInfo(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
    }
    public static void LogWarning(string message)
    {
        Console.WriteLine($"[WARNING] {DateTime.Now}: {message}");
    }
    public static void LogError(string message)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now}: {message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger.LogInfo("Программа запущена.");
        Logger.LogWarning("Это предупреждение о возможной проблеме.");
        Logger.LogError("Произошла ошибка при выполнении операции.");
        Logger.LogInfo("Загрузка данных...");
        Logger.LogWarning("Данные загружаются медленно.");
        Logger.LogError("Не удалось загрузить данные.");
    }
}