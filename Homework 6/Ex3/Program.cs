public class ArrayService
{
    // ... (предыдущий код)

    public static int SumIntArray(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    public static void Main()
    {
        int size = 10;
        int min = -10;
        int max = 10;

        int[] randomArray = GenerateRandomArray(size, min, max);

        PrintIntArray(randomArray);

        int sum = SumIntArray(randomArray);
        Console.WriteLine("\nСумма чисел в массиве: " + sum);
    }
}