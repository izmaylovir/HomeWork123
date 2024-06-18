public class ArrayService
{
    public static int FindMinValueIndex(int[] array)
    {
        if (array.Length == 0)
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

    public static void Main()
    {
        int[] numbers = { 10, 5, 8, 20, 3 };
        int minIndex = FindMinValueIndex(numbers);
        Console.WriteLine("Индекс минимального значения в массиве: " + minIndex);
    }
}