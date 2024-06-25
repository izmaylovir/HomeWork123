public class ArrayService
{
    public static void ReverseArray(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;
            right--;
        }
    }

    public static void Main()
    {
        int[] originalArray = new int[] { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        foreach (int num in originalArray)
        {
            Console.Write(num + " ");
        }

        ReverseArray(originalArray);

        Console.WriteLine("\nМассив после переворота:");
        foreach (int num in originalArray)
        {
            Console.Write(num + " ");
        }
    }
}