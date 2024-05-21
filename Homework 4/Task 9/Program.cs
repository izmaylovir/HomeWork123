class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] reversedArray = ReverseArray(array);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(reversedArray);
    }
    static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }

        return reversedArray;
    }
    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}