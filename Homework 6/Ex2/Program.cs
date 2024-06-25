public class ArrayService
{
    public static int[] GenerateRandomArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(min, max + 1);
        }

        return array;
    }

    public static void PrintIntArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }

    public static void Main()
    {
        int size = 10;
        int min = -10;
        int max = 10;

        int[] randomArray = GenerateRandomArray(size, min, max);

        PrintIntArray(randomArray);
    }
}