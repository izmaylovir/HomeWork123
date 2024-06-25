public class ArrayService
{
    public static int[] GetEvenNumbers(int[] array)
    {
        List<int> evenNumbersList = new List<int>();

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                evenNumbersList.Add(number);
            }
        }

        return evenNumbersList.ToArray();
    }

    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] evenNumbers = GetEvenNumbers(numbers);

        Console.WriteLine("Четные числа из исходного массива:");
        foreach (int number in evenNumbers)
        {
            Console.Write(number + " ");
        }
    }
}