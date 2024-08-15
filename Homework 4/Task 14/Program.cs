class Program
{
    static void Main()
    {
        string inputString = "Hello, World!";
        char[] charArray = StringToCharArray(inputString);

        Console.WriteLine("String: " + inputString);
        Console.WriteLine("Converted to char array:");
        foreach (var ch in charArray)
        {
            Console.Write(ch + " ");
        }
    }
    static char[] StringToCharArray(string input)
    {
        char[] charArray = input.ToCharArray();
        return charArray;
    }
}