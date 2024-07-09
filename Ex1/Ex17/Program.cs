using System.Text.RegularExpressions;

public class RussianAlphabetUtils
{
    public static int CountRussianAlphabetCharacters(string text)
    {
        string russianAlphabetPattern = "[а-яёА-ЯЁ]";
        Regex regex = new Regex(russianAlphabetPattern);

        MatchCollection matches = regex.Matches(text);
        return matches.Count;
    }

    public static void Main()
    {
        string text = "Пример текста с русскими символами: Я люблю русский язык!";
        int count = CountRussianAlphabetCharacters(text);

        Console.WriteLine("Количество символов русского алфавита в тексте: " + count);
    }
}