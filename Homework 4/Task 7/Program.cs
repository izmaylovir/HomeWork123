class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 7, 1, 9 };
        int minIndex = FindMinIndex(numbers);

        Console.WriteLine($"Индекс минимального элемента в массиве: {minIndex}");
    }
    static int FindMinIndex(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым");
        }
        int minIndex = 0;
        int minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
                minIndex = i;
            }
        }
        return minIndex;
    }
}
