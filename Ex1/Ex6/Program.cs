public class CharacterCounter
{
    public static int CountCharacterOccurrences(string inputString, char character)
    {
        int count = 0;
        foreach (char c in inputString)
        {
            if (c == character)
            {
                count++;
            }
        }
        return count;
    }

    public static void Main()
    {
        string inputString = "Hello, World!";
        char characterToCount = 'l';

        int occurrences = CountCharacterOccurrences(inputString, characterToCount);

        Console.WriteLine($"Символ '{characterToCount}' встречается {occurrences} раз в строке '{inputString}'.");
    }
}