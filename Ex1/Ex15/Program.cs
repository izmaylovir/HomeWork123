public class RussianAlphabetUtils
{
    public static string GetRussianAlphabet()
    {
        string russianAlphabetLower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string russianAlphabetUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        return russianAlphabetUpper + russianAlphabetLower;
    }

    public static void Main()
    {
        string russianAlphabet = GetRussianAlphabet();

        Console.WriteLine("Русский алфавит: " + russianAlphabet);
    }
}