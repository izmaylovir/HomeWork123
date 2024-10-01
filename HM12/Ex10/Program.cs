namespace l6t10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            int number;
            if (Int32.TryParse(input, out number))
            {
                Console.WriteLine($"Введенное число: {number}");
            }
            else
            {
                Console.WriteLine("Ошибка парсинга!");
            }
        }
    }
}