public class ArrayService
{
    public static int FindMaxValue(int[] array)
    {
        if (array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым");
        }

        int maxValue = array[0];
        foreach (int value in array)
        {
            if (value > maxValue)
            {
                maxValue = value;
            }
        }

        return maxValue;
    }

    public static void Main()
    {
        int[] numbers = { 10, 5, 8, 20, 3 };
        int maxValue = FindMaxValue(numbers);
        Console.WriteLine("Максимальное значение в массиве: " + maxValue);
    }
}