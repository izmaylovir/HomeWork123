public class MostFrequentCharFinder
{
    public static char FindMostFrequentChar(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        char mostFrequentChar = charCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

        return mostFrequentChar;
    }

    public static void Main()
    {
        string input = "hello world";
        char mostFrequentChar = FindMostFrequentChar(input);

        Console.WriteLine("The most frequent character in the string '" + input + "' is: " + mostFrequentChar);
    }
}