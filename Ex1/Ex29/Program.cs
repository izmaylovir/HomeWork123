public class LongestCommonSubstringFinder
{
    public static string FindLongestCommonSubstring(string[] strings)
    {
        if (strings == null || strings.Length == 0)
        {
            return "";
        }
        string firstString = strings[0];
        int maxLength = 0;
        string longestCommonSubstring = "";

        for (int i = 0; i < firstString.Length; i++)
        {
            for (int j = i + 1; j <= firstString.Length; j++)
            {
                string substring = firstString.Substring(i, j - i);
                bool allContain = strings.All(s => s.Contains(substring));

                if (allContain && substring.Length > maxLength)
                {
                    maxLength = substring.Length;
                    longestCommonSubstring = substring;
                }
            }
        }

        return longestCommonSubstring;
    }
    public static void Main()
    {
        string[] inputStrings = { "abcdefg", "bcdefghij", "cdef" };
        string longestCommonSubstring = FindLongestCommonSubstring(inputStrings);

        Console.WriteLine("Input strings:");
        foreach (string str in inputStrings)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Longest common substring: " + longestCommonSubstring);
    }
}