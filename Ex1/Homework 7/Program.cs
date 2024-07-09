public class PalindromeChecker
{
    public static bool IsPalindrome(string text)
    {
        string cleanText = new string(text.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        int left = 0;
        int right = cleanText.Length - 1;

        while (left < right)
        {
            if (cleanText[left] != cleanText[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    public static void Main()
    {
        string text = "He watch tv";
        Console.WriteLine(IsPalindrome(text)); 
    }
}
