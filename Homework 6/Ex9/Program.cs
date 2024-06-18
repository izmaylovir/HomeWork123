public class ArrayService
{
    public static int FindValueIndex(int[] array, int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return i;
            }
        }

        return -1;
    }

    public static void Main()
    {
        int[] numbers = { 10, 5, 8, 20, 3 };
        int valueToFind = 8;
        int index = FindValueIndex(numbers, valueToFind);

        if (index != -1)
        {
            Console.WriteLine($"Индекс числа {valueToFind} в массиве: " + index);
        }
        else
        {
            Console.WriteLine($"Число {valueToFind} не найдено в массиве");
        }
    }
}