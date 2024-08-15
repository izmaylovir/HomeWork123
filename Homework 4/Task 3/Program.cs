class Program
{
    static void Main(string[] args)
    {
        int min = 1;
        int max = 100;
        int randomNumber = GetRandomNumber(min, max);
        Console.WriteLine($"Случайное число в диапазоне от {min} до {max}: {randomNumber}");
    }
    static int GetRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
}