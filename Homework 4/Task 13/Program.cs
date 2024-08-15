class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int increaseBy = 10;
        int[] result = new int[numbers.Length];

        IncreaseArrayByValue(numbers, increaseBy, out result);

        Console.WriteLine("Original array:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nArray after increasing by " + increaseBy + ":");
        foreach (var num in result)
        {
            Console.Write(num + " ");
        }
    }
    static void IncreaseArrayByValue(int[] array, int value, out int[] result)
    {
        result = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i] + value;
        }
    }
}