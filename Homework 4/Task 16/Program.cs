class Program
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        Console.WriteLine("String 1: " + str1);
        Console.WriteLine("String 2: " + str2);
        Console.WriteLine("Are they anagrams? " + IsAnagram(str1, str2));
    }
    static bool IsAnagram(string str1, string str2)
    {     
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();
        char[] charArray1 = str1.ToCharArray();
        char[] charArray2 = str2.ToCharArray();
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        return charArray1.SequenceEqual(charArray2);
    }
}