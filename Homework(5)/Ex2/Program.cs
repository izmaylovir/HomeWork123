class NumberService
{
    public void PrintEvenNumbers(int number)
    {
        Console.WriteLine("Четные числа от 0 до " + number + ":");
        for (int i = 0; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}