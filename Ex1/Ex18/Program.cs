public class EnglishAlphabetUtils
{
    public static int CountEnglishAlphabetCharacters(string text)
    {
        string englishAlphabetPattern = "[a-zA-Z]";
        Regex regex = new Regex(englishAlphabetPattern);

        MatchCollection matches = regex.Matches(text);
        return matches.Count;
    }

    public static void Main()
    {
        string text = "This is an example text with English characters: I love the English language!";
        int count = CountEnglishAlphabetCharacters(text);

        Console.WriteLine("The number of English alphabet characters in the text: " + count);
    }
}