namespace l6t15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetMaxValue(new int[] { 1, 2, 3, 3, 4, 1, 1, 231, 33, 13, 1231, 313, 2213, 31, 1, 312, 321, 1, 1, 2, 32, 3556, 6, 8576, 43, 8, 2 }));
            Console.WriteLine(GetMaxValue(new int[] { 8, 5652, -3457, 3, 34, 23, 143, 7, 647, 4, -8, 56, 75, 243, 45, 98, 65767, 252, 42351, 12, 2, 3, 1, 23, 6 }));
            Console.WriteLine(GetMaxValue(new int[] { 0 }));
        }
        public static int GetMaxValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым.");
            }
            int maxValue = numbers[0];
            foreach (int number in numbers)
            {
                if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            return maxValue;
        }
    }
}