public class ArrayService
{
    public static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int evenCount = CountEvenNumbers(numbers);
        Console.WriteLine("Количество четных чисел: " + evenCount);
    }
}
