public class LongestWordFinder
{
    public static string FindLongestWord(string input)
    {
        char[] delimiters = { ' ', ',', '.', '!', '?', ':', ';' };
        string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }
    public static void Main()
    {
        string input = "This is a sample text with the longest word being 'elephant'.";
        string longestWord = FindLongestWord(input);

        Console.WriteLine("Text: " + input);
        Console.WriteLine("Longest word: " + longestWord);
    }
}