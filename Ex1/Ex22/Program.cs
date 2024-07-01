public class WordCounter
{
    public static int CountWords(string input)
    {
        char[] delimiters = { ' ', ',', '.', '!', '?', ':', ';' };
        string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
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