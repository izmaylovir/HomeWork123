class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = GetAverage(numbers);
        Console.WriteLine($"Среднее значение: {average}");
    }

    static double GetAverage(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}