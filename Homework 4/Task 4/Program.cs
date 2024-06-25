class Program
{
    static void Main(string[] args)
    {
        int number = 17;
        bool isPrime = IsPrime(number);

        if (isPrime)
        {
            Console.WriteLine($"{number} - простое число");
        }
        else
        {
            Console.WriteLine($"{number} - не является простым числом");
        }
    }
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
