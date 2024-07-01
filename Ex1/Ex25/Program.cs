public class MaxConsecutiveChars
{
    public static int FindMaxConsecutiveChars(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }
    public static void Main()
    {
        string input = "aaabbcccdddddddeeeeee";
        int maxConsecutiveChars = FindMaxConsecutiveChars(input);

        Console.WriteLine("Input text: " + input);
        Console.WriteLine("Max consecutive characters: " + maxConsecutiveChars);
    }
}