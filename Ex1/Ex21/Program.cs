public class TextReverser
{
    public static string ReverseText(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static void Main()
    {
        string input = "Hello, World!";
        string reversedText = ReverseText(input);

        Console.WriteLine("Original text: " + input);
        Console.WriteLine("Reversed text: " + reversedText);
    }
}