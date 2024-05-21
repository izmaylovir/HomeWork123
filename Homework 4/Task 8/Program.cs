class Program
{
    static void Main(string[] args)
    {
        string input = "Пример строки с несколькими словами";
        int wordCount = CountWords(input);

        Console.WriteLine($"Количество слов в строке: {wordCount}");
    }
    static int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int wordCount = 0;
        bool inWord = false;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                if (!inWord)
                {
                    wordCount++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }

        return wordCount;
    }
}