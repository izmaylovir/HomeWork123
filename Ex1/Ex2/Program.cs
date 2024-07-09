public class AnagramChecker
{
    public static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in str1)
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

        foreach (char c in str2)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]--;
                if (charCount[c] == 0)
                {
                    charCount.Remove(c);
                }
            }
            else
            {
                return false;
            }
        }

        return charCount.Count == 0;
    }

    public static void Main()
    {
        string word1 = "Athur";
        string word2 = "Dmitriy";
        Console.WriteLine(AreAnagrams(word1, word2)); 
    }
}