
public class ArrayService
{
    public static int[] ResizeArray(int[] array, int newSize)
    {
        int[] newArray = new int[newSize];

        for (int i = 0; i < newSize; i++)
        {
            if (i < array.Length)
            {
                newArray[i] = array[i];
            }
            else
            {
                newArray[i] = 0; // Заполнение оставшихся элементов массива нулями
            }
        }

        return newArray;
    }

    public static void Main()
    {
        int[] originalArray = new int[] { 1, 2, 3, 4, 5 };
        int newSize = 7;

        int[] resizedArray = ResizeArray(originalArray, newSize);

        Console.WriteLine("Исходный массив:");
        foreach (int num in originalArray)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nМассив с новой размерностью:");
        foreach (int num in resizedArray)
        {
            Console.Write(num + " ");
        }
    }
}