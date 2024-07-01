public class WordUtils
{
    public static char GetFirstLetter(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            throw new ArgumentException("Слово не может быть пустым.");
        }

        return word[0];
    }

    public static void Main()
    {
        string word = "Привет";

        char firstLetter = GetFirstLetter(word);

        Console.WriteLine("Первая буква слова '" + word + "': " + firstLetter);
    }
}