public class ArrayService
{
    public static int FindMaxValueIndex(int[] array)
    {
        if (array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым");
        }

        int maxIndex = 0;
        int maxValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static void Main()
    {
        int[] numbers = { 10, 5, 8, 20, 3 };
        int maxIndex = FindMaxValueIndex(numbers);
        Console.WriteLine("Индекс максимального значения в массиве: " + maxIndex);
    }
}
