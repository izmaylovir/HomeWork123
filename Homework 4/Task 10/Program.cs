class Program
{
    static void Main(string[] args)
    {
        string str1 = "123";
        string str2 = "abc";

        Console.WriteLine("Строка 1: " + str1);
        Console.WriteLine("Результат: " + IsNumeric(str1));

        Console.WriteLine("Строка 2: " + str2);
        Console.WriteLine("Результат: " + IsNumeric(str2));
    }
    static bool IsNumeric(string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        foreach (char c in str)
        {
            if (!char.IsDigit(c))
                return false;
        }

        return true;
    }
}