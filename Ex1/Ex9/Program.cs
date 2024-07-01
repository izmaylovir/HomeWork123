public class StringSplitter
{
    public static string[] SplitString(string text, char delimiter)
    {
        string[] result = text.Split(delimiter);
        return result;
    }

    public static void Main()
    {
        string text = "разделение;строки;по;символу";
        char delimiter = ';';

        string[] splitStrings = SplitString(text, delimiter);

        Console.WriteLine("Результат разделения:");
        foreach (string str in splitStrings)
        {
            Console.WriteLine(str);
        }
    }
}