public class WordUtils
{
    public static string CapitalizeFirstLetter(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            throw new ArgumentException("Слово не может быть пустым.");
        }

        char firstLetter = char.ToUpper(word[0]);
        string capitalizedWord = firstLetter + word.Substring(1);

        return capitalizedWord;
    }

    public static void Main()
    {
        string word = "привет";

        string capitalizedWord = CapitalizeFirstLetter(word);

        Console.WriteLine("Слово с заглавной буквы: " + capitalizedWord);
    }
}