public class WordSplitter
{
    public static string[] SplitStringIntoWords(string input)
    {

        char[] delimiters = { ' ', ',', '.', '!', '?' }; 

        string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        return words;
    }

    public static void Main()
    {
        string inputString = "Этот метод разделяет строку на массив слов.";
        string[] result = SplitStringIntoWords(inputString);

        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }
}