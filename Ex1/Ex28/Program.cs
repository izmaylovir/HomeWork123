public class NumberCounter
{
    public static int CountNumbers(string inputString)
    {
        int numberCount = 0;
        bool inNumber = false;

        foreach (char c in inputString)
        {
            if (char.IsDigit(c))
            {
                if (!inNumber)
                {
                    numberCount++;
                    inNumber = true;
                }
            }
            else
            {
                inNumber = false;
            }
        }

        return numberCount;
    }

    public static void Main()
    {
        string inputString = "Hello123World456";
        int numberCount = CountNumbers(inputString);

        Console.WriteLine("Input string: " + inputString);
        Console.WriteLine("Number of numbers: " + numberCount);
    }
}