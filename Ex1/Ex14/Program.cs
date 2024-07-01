public class SubstringUtils
{
    public static string GetSubstring(string input, int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex >= input.Length || endIndex < 0 || endIndex >= input.Length || startIndex > endIndex)
        {
            throw new ArgumentException("Неверные индексы начала и конца подстроки.");
        }

        return input.Substring(startIndex, endIndex - startIndex + 1);
    }

    public static void Main()
    {
        string input = "Пример строки для извлечения подстроки";
        int startIndex = 8;
        int endIndex = 14;

        string substring = GetSubstring(input, startIndex, endIndex);

        Console.WriteLine("Подстрока: " + substring);
    }
}