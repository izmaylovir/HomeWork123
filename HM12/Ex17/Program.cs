namespace l6t17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = GetArrayFromConsole(10);
            Console.WriteLine($"Количество элементов массива: {arr.Length}");
            Console.WriteLine($"Минимальная длина элемента массива: {arr.Min(s => s.Length)}");
            Console.WriteLine($"Максимальная длина элемента массива: {arr.Max(s => s.Length)}");
            if (arr.Length >= 5)
            {
                Console.WriteLine($"5-й элемент массива: {arr[4]}");
            }
            else
            {
                Console.WriteLine("5-й элемент массива отсутствует.");
            }

            if (arr.Length >= 10)
            {
                Console.WriteLine($"10-й элемент массива: {arr[9]}");
            }
            else
            {
                Console.WriteLine("10-й элемент массива отсутствует.");
            }
        }

        public static string[] GetArrayFromConsole(int x)
        {
            if (x < 1) x = 1;
            if (x > 10) x = 10;

            string[] arr = new string[x];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите строку для элемента {i + 1}: ");
                arr[i] = Console.ReadLine();
            }

            return arr;
        }
    }
}