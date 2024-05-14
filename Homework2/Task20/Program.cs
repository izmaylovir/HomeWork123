{
    static void Main()
    {
        int[] numbers = new int[4];

        Console.WriteLine("Введите четыре числа:");

        for (int i = 0; i < 4; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("Числа в порядке убывания:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}