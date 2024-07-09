public class WordCounter
{
    public static int CountWordOccurrences(string text, string word)
    {
        char[] delimiters = { ' ', ',', '.', '!', '?', ':', ';', '"', '\'', '(', ')', '[', ']', '{', '}' };

        string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;
        foreach (string w in words)
        {
            if (w.Equals(word, StringComparison.OrdinalIgnoreCase)) 
            {
                count++;
            }
        }

        return count;
    }

    public static void Main()
    {
        string inputText = "Этот метод считает количество вхождений слова в строку. Метод метод метод.";
        string wordToCount = "метод";

        int occurrences = CountWordOccurrences(inputText, wordToCount);

        Console.WriteLine($"Слово \"{wordToCount}\" встречается в тексте {occurrences} раз.");
    }
}