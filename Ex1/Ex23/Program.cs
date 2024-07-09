public class WordCounter
{
    public static int CountWords(string input)
    {
        // Разделители слов (пробел, запятая, точка, восклицательный знак и другие)
        char[] delimiters = { ' ', ',', '.', '!', '?', ':', ';' };

        // Разбиваем строку на слова с помощью метода Split
        string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        // Возвращаем количество слов
        return words.Length;
    }

    public static void Main()
    {
        string input = "This is a sample text with 7 words.";
        int wordCount = CountWords(input);

        Console.WriteLine("Text: " + input);
        Console.WriteLine("Number of words: " + wordCount);
    }
}