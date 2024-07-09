public class DigitCounter
{
    public static int CountDigits(string inputString)
    {
        int digitCount = 0;

        foreach (char c in inputString)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        return digitCount;
    }

    public static void Main()
    {
        string inputString = "Hello123World456";
        int digitCount = CountDigits(inputString);

        Console.WriteLine("Input string: " + inputString);
        Console.WriteLine("Number of digits: " + digitCount);
    }
}