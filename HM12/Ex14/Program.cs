namespace l6t14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 целых чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}