class Program
{
    static void Main(string[] args)
    {
        string str = "level";
        bool isPalindrome = IsPalindrome(str);

        Console.WriteLine($"Строка \"{str}\" является палиндромом: {isPalindrome}");
    }
    static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
