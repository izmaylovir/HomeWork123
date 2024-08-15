class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Среднее значение чисел 2, 4, 6: " + GetAverage(2, 4, 6));
        Console.WriteLine("Среднее значение чисел 10, 20, 30, 40: " + GetAverage(10, 20, 30, 40));
    }
    static double GetAverage(params int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }
}