class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        ShuffleArray(array);

        Console.WriteLine("Перемешанный массив:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
    }
    static void ShuffleArray(int[] array)
    {
        Random random = new Random();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}